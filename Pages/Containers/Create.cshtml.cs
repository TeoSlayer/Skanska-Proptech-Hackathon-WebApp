using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using SPHackathon.Data;
using SPHackathon.Models;
using SPHackathon.Models.Documents.Legal;
using SPHackathon.Models.Documents.Misc;

namespace SPHackathon.Pages.Containers
{
    public class CreateModel : PageModel
    {
        #region Private Fields

        private readonly SPHackathon.Data.ApplicationDbContext _context;

        #endregion Private Fields

        #region Public Constructors

        public CreateModel(SPHackathon.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        #endregion Public Constructors

        #region Public Properties

        [BindProperty]
        public Container Container { get; set; }

        #endregion Public Properties

        #region Public Methods

        public IActionResult OnGet()
        {
            return Page();
        }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            Container.LandBookRegistrations = new List<LandBookRegistration>();
            Container.Letters = new List<Letter>();
            _context.Container.Add(Container);
            await _context.SaveChangesAsync();

            return RedirectToPage("/Index");
        }

        #endregion Public Methods

        /*
        public async Task<IActionResult> OnPostTeamsAsync()
        {
            microsoftTeams.initialize();

            // Check the initial theme user chose and respect it
            microsoftTeams.getContext(function(context) {
                if (context && context.theme)
                {
                    setTheme(context.theme);
                }
            });

            // Handle theme changes
            microsoftTeams.registerOnThemeChangeHandler(function(theme) {
                setTheme(theme);
            });

            // Save configuration changes
            microsoftTeams.settings.registerOnSaveHandler(function(saveEvent) {
                // Let the Microsoft Teams platform know what you want to load based on
                // what the user configured on this page
                microsoftTeams.settings.setSettings({
                    contentUrl: createTabUrl(), // Mandatory parameter
      entityId: createTabUrl() // Mandatory parameter
    });

                // Tells Microsoft Teams platform that we are done saving our settings. Microsoft Teams waits
                // for the app to call this API before it dismisses the dialog. If the wait times out, you will
                // see an error indicating that the configuration settings could not be saved.
                saveEvent.notifySuccess();
            });

            // Logic to let the user configure what they want to see in the tab being loaded
            document.addEventListener('DOMContentLoaded', function() {
                var tabChoice = document.getElementById('tabChoice');
                if (tabChoice)
                {
                    tabChoice.onchange = function() {
                        var selectedTab = this[this.selectedIndex].value;

                        // This API tells Microsoft Teams to enable the 'Save' button. Since Microsoft Teams always assumes
                        // an initial invalid state, without this call the 'Save' button will never be enabled.
                        microsoftTeams.settings.setValidityState(selectedTab === 'first' || selectedTab === 'second');
                    };
                }
            });

            // Set the desired theme
            function setTheme(theme)
            {
                if (theme)
                {
                    // Possible values for theme: 'default', 'light', 'dark' and 'contrast'
                    document.body.className = 'theme-' + (theme === 'default' ? 'light' : theme);
                }
            }

            // Create the URL that Microsoft Teams will load in the tab. You can compose any URL even with query strings.
            function createTabUrl()
            {
                var tabChoice = document.getElementById('tabChoice');
                var selectedTab = tabChoice[tabChoice.selectedIndex].value;

                return window.location.protocol + '//' + window.location.host + '/' + selectedTab;
            }*/
    }
}