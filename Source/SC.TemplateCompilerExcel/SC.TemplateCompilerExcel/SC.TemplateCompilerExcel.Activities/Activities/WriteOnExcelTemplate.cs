using System;
using System.Activities;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using SC.TemplateCompilerExcel.Activities.Properties;
using UiPath.Shared.Activities;
using UiPath.Shared.Activities.Localization;

namespace SC.TemplateCompilerExcel.Activities
{
    [LocalizedDisplayName(nameof(Resources.WriteOnExcelTemplate_DisplayName))]
    [LocalizedDescription(nameof(Resources.WriteOnExcelTemplate_Description))]
    public class WriteOnExcelTemplate : ContinuableAsyncCodeActivity
    {
        #region Properties

        /// <summary>
        /// If set, continue executing the remaining activities even if the current activity has failed.
        /// </summary>
        [LocalizedCategory(nameof(Resources.Common_Category))]
        [LocalizedDisplayName(nameof(Resources.ContinueOnError_DisplayName))]
        [LocalizedDescription(nameof(Resources.ContinueOnError_Description))]
        public override InArgument<bool> ContinueOnError { get; set; }

        [LocalizedDisplayName(nameof(Resources.WriteOnExcelTemplate_ExcelPath_DisplayName))]
        [LocalizedDescription(nameof(Resources.WriteOnExcelTemplate_ExcelPath_Description))]
        [LocalizedCategory(nameof(Resources.Input_Category))]
        public InArgument<string> ExcelPath { get; set; }

        [LocalizedDisplayName(nameof(Resources.WriteOnExcelTemplate_InputDict_DisplayName))]
        [LocalizedDescription(nameof(Resources.WriteOnExcelTemplate_InputDict_Description))]
        [LocalizedCategory(nameof(Resources.Input_Category))]
        public InArgument<Dictionary<string, string>> InputDict { get; set; }

        [LocalizedDisplayName(nameof(Resources.WriteOnExcelTemplate_DeleteUnreplacedPlaceholder_DisplayName))]
        [LocalizedDescription(nameof(Resources.WriteOnExcelTemplate_DeleteUnreplacedPlaceholder_Description))]
        [LocalizedCategory(nameof(Resources.Input_Category))]
        public InArgument<bool> DeleteUnreplacedPlaceholder { get; set; }

        #endregion


        #region Constructors

        public WriteOnExcelTemplate()
        {
        }

        #endregion


        #region Protected Methods

        protected override void CacheMetadata(CodeActivityMetadata metadata)
        {
            if (ExcelPath == null) metadata.AddValidationError(string.Format(Resources.ValidationValue_Error, nameof(ExcelPath)));
            if (InputDict == null) metadata.AddValidationError(string.Format(Resources.ValidationValue_Error, nameof(InputDict)));

            base.CacheMetadata(metadata);
        }

        protected override async Task<Action<AsyncCodeActivityContext>> ExecuteAsync(AsyncCodeActivityContext context, CancellationToken cancellationToken)
        {
            // Inputs
            var excelpath = ExcelPath.Get(context);
            var inputdict = InputDict.Get(context);
            var deleteunreplacedplaceholder = DeleteUnreplacedPlaceholder.Get(context);
    
            ///////////////////////////
            // Add execution logic HERE
            ///////////////////////////

            // Outputs
            return (ctx) => {
            };
        }

        #endregion
    }
}

