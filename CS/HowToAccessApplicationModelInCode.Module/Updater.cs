using System;

using DevExpress.ExpressApp.Updating;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using DevExpress.Persistent.BaseImpl;

namespace HowToAccessApplicationModelInCode.Module {
   public class Updater : ModuleUpdater {
      public Updater(Session session, Version currentDBVersion) : base(session, currentDBVersion) { }
      public override void UpdateDatabaseAfterUpdateSchema() {
         base.UpdateDatabaseAfterUpdateSchema();
         if (Session.FindObject<Contact>(CriteriaOperator.Parse(
           "FirstName == 'Mary' && LastName == 'Tellitson'")) == null) {
             Contact contact = new Contact(Session);
             contact.FirstName = "Mary";
             contact.LastName = "Tellitson";
             contact.Email = "tellitson@example.com";
             contact.Save();
         }
         if (Session.FindObject<Contact>(CriteriaOperator.Parse(
          "FirstName == 'Andrew' && LastName == 'Fuller'")) == null) {
             Contact contact = new Contact(Session);
             contact.FirstName = "Andrew";
             contact.LastName = "Fuller";
             contact.Email = "fuller@example.com";
             contact.Save();
         }
      }
   }
}
