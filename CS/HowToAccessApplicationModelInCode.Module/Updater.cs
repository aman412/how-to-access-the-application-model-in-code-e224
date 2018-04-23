using System;

using DevExpress.ExpressApp.Updating;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.Persistent.BaseImpl;

namespace HowToAccessApplicationModelInCode.Module {
    public class Updater : ModuleUpdater {
        public Updater(IObjectSpace objectSpace, Version currentDBVersion) : base(objectSpace, currentDBVersion) { }
        public override void UpdateDatabaseAfterUpdateSchema() {
            base.UpdateDatabaseAfterUpdateSchema();
            if (ObjectSpace.FindObject<Contact>(CriteriaOperator.Parse(
              "FirstName == 'Mary' && LastName == 'Tellitson'")) == null) {
                Contact contact = ObjectSpace.CreateObject<Contact>();
                contact.FirstName = "Mary";
                contact.LastName = "Tellitson";
                contact.Email = "tellitson@example.com";
                contact.Save();
            }
            if (ObjectSpace.FindObject<Contact>(CriteriaOperator.Parse(
             "FirstName == 'Andrew' && LastName == 'Fuller'")) == null) {
                Contact contact = ObjectSpace.CreateObject<Contact>();
                contact.FirstName = "Andrew";
                contact.LastName = "Fuller";
                contact.Email = "fuller@example.com";
                contact.Save();
            }
        }
    }
}
