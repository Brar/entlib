﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Console.Wpf.Tests.VSTS.DevTests.Contexts;
using Microsoft.Practices.EnterpriseLibrary.Configuration.Design.ViewModel.BlockSpecifics;
using Microsoft.Practices.EnterpriseLibrary.Configuration.Design.ViewModel;
using Microsoft.Practices.EnterpriseLibrary.Configuration.EnvironmentalOverrides.Configuration;
using Microsoft.Practices.Unity;
using Microsoft.Practices.EnterpriseLibrary.Configuration.Console;
using System.IO;
using Console.Wpf.Tests.VSTS.TestSupport;

namespace Console.Wpf.Tests.VSTS.DevTests.given_save_environment_delta_command
{

    [TestClass]
    public class when_saving_environment_delta_file_with_non_rooted_filename : ContainerContext
    {
        EnvironmentalOverridesViewModel overridesModel;
        string targetFile;

        protected override void Arrange()
        {
            base.Arrange();

            ApplicationViewModel applicationModel = base.Container.Resolve<ApplicationViewModel>();
            applicationModel.ConfigurationFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "main.config");

            overridesModel = (EnvironmentalOverridesViewModel)SectionViewModel.CreateSection(Container, EnvironmentMergeSection.EnvironmentMergeData, new EnvironmentMergeSection
            {
                EnvironmentName = "environment"
            });
            overridesModel.EnvironmentDeltaFile = "non_rooted_environment.dconfig";
            targetFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, overridesModel.EnvironmentDeltaFile);
        }

        protected override void Act()
        {
            overridesModel.SaveDelta();
        }

        [TestMethod]
        public void then_environment_is_saved_in_main_file_directory()
        {
            Assert.IsTrue(File.Exists(targetFile));
        }

        protected override void Teardown()
        {
            File.Delete(targetFile);
        }
    }
}
