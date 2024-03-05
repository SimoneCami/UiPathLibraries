using System.Activities.Presentation.Metadata;
using System.ComponentModel;
using System.ComponentModel.Design;
using SC.TemplateCompilerExcel.Activities.Design.Designers;
using SC.TemplateCompilerExcel.Activities.Design.Properties;

namespace SC.TemplateCompilerExcel.Activities.Design
{
    public class DesignerMetadata : IRegisterMetadata
    {
        public void Register()
        {
            var builder = new AttributeTableBuilder();
            builder.ValidateTable();

            var categoryAttribute = new CategoryAttribute($"{Resources.Category}");

            builder.AddCustomAttributes(typeof(WriteOnExcelTemplate), categoryAttribute);
            builder.AddCustomAttributes(typeof(WriteOnExcelTemplate), new DesignerAttribute(typeof(WriteOnExcelTemplateDesigner)));
            builder.AddCustomAttributes(typeof(WriteOnExcelTemplate), new HelpKeywordAttribute(""));


            MetadataStore.AddAttributeTable(builder.CreateTable());
        }
    }
}
