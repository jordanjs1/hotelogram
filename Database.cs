using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
//using VDS.RDF;
//using VDS.RDF.Parsing;
//using VDS.RDF.Query;
//using VDS.RDF.Query.Datasets;
//using VDS.RDF.Writing;
//using VDS.RDF.Writing.Formatting;

namespace Hotelogram
{
    /// <summary>
    /// Holds the definitions of the <see cref="User"/>s of the program.
    /// </summary>
    public static class Database
    {
        //public static IGraph RDFDatabase { get; set; } = new Graph();
        public static User UserMert { get; set; }
        public static User UserInfraTau { get; set; }
        public static User UserViewOnly { get; set; }
        public static User UserGuest { get; set; }

        public static Uri Reserved = new Uri("hotelogram://reserved_room");
        public static Uri Registered = new Uri("hotelogram://registered_room");
        public static Uri HasBill = new Uri("hotelogram://has_bill");
        public static Uri HasAction = new Uri("hotelogram://has_action");
        public static Uri HasFurniture = new Uri("hotelogram://has_furniture");
        public static List<Uri> Rooms { get; set; } = new List<Uri>();
        public static List<Uri> Guests { get; set; } = new List<Uri>();
        public static List<Uri> Employees { get; set; } = new List<Uri>();

        public static void LoadUsers()
        {
            UserMert = new User("Admin", "Admin");
            UserInfraTau = new User("InfraTau", "Particle.28");
            UserViewOnly = new User("View", "");
            UserGuest = new User("Guest", "");

            UserMert.Permissions = new PermissionInfo
            {
                EmployeePermissions = EmployeePermission.All,
                GuestPermissions = GuestPermission.All,
                InventoryPermissions = InventoryPermission.All,
                RoomPermissions = RoomPermission.All,
                UserPermissions = UserPermission.All
            };

            UserInfraTau.Permissions = new PermissionInfo
            {
                EmployeePermissions = EmployeePermission.View | EmployeePermission.Add | EmployeePermission.Edit | EmployeePermission.ViewReports | EmployeePermission.AddReport,
                GuestPermissions = GuestPermission.View | GuestPermission.Register | GuestPermission.Reserve | GuestPermission.Edit | GuestPermission.ViewGuestBill | GuestPermission.EditGuestBill,
                InventoryPermissions = InventoryPermission.View | InventoryPermission.Add | InventoryPermission.Edit,
                RoomPermissions = RoomPermission.View | RoomPermission.Add | RoomPermission.Edit,
                UserPermissions = UserPermission.View
            };

            UserViewOnly.Permissions = new PermissionInfo
            {
                EmployeePermissions = EmployeePermission.View | EmployeePermission.ViewReports,
                GuestPermissions = GuestPermission.View | GuestPermission.ViewGuestBill,
                InventoryPermissions = InventoryPermission.View,
                RoomPermissions = RoomPermission.View,
                UserPermissions = UserPermission.View
            };

            UserGuest.Permissions = new PermissionInfo
            {
                EmployeePermissions = EmployeePermission.None,
                GuestPermissions = GuestPermission.None,
                InventoryPermissions = InventoryPermission.None,
                RoomPermissions = RoomPermission.None,
                UserPermissions = UserPermission.None
            };

            User.AllUsers.Add(UserMert);
            User.AllUsers.Add(UserGuest);
            User.AllUsers.Add(UserInfraTau);
            User.AllUsers.Add(UserViewOnly);
            User.AllUsers.Add(User.NullUser);
        }

        //UNUSED CODE: This portion of code was meant to be used for RDF stuff, but this project is not designed to have a RDF database. The RDF system was temporarily added because of a re-presentation of the project demonstrating a RDF database system.
        //public static void MakeGuestRoomTriple(Guest guest, bool reservedOrRegistered, Room room)
        //{
        //    var guestNode = RDFDatabase.CreateLiteralNode($"Guest {guest.Name}");
        //    //var actionNode = reservedOrRegistered
        //    //    ? RDFDatabase.CreateLiteralNode("Reserved")
        //    //    : RDFDatabase.CreateLiteralNode("Registered");
        //    var actionNode = reservedOrRegistered
        //        ? RDFDatabase.CreateUriNode(Reserved)
        //        : RDFDatabase.CreateUriNode(Registered);
        //    var roomNode = RDFDatabase.CreateLiteralNode(room != null ? $"Room #{room.No}" : "No Room");

        //    RDFDatabase.Assert(new Triple(guestNode, actionNode, roomNode));
        //}

        //public static void MakeGuestBillTriple(Guest guest, Bill bill)
        //{
        //    var guestNode = RDFDatabase.CreateLiteralNode($"Guest {guest.Name}");
        //    var hasNode = RDFDatabase.CreateUriNode(HasBill);
        //    var billNode = RDFDatabase.CreateLiteralNode(bill != null ? $"Bill #{bill.ID}" : "No Bill");
        //    RDFDatabase.Assert(new Triple(guestNode, hasNode, billNode));
        //}

        //public static void MakeBillActionTriple(Bill bill, Bill.Action action)
        //{
        //    var billNode = RDFDatabase.CreateLiteralNode($"Bill #{bill.ID}");
        //    var hasNode = RDFDatabase.CreateUriNode(HasAction);
        //    var actionNode = RDFDatabase.CreateLiteralNode($"Action #{action.ActionID}");
        //    RDFDatabase.Assert(new Triple(billNode, hasNode, actionNode));
        //}

        //public static void MakeRoomFurnitureTriple(Room room, Furniture furniture)
        //{
        //    var roomNode = RDFDatabase.CreateLiteralNode($"Room #{room.No}");
        //    var hasNode = RDFDatabase.CreateUriNode(HasFurniture);
        //    var furnitureNode = RDFDatabase.CreateLiteralNode($"{furniture.Name} ({furniture.Count})");
        //    RDFDatabase.Assert(new Triple(roomNode, hasNode, furnitureNode));
        //}

        //public static SparqlResultSet QueryAgainstDatabase(string queryInput)
        //{
        //    var parser = new SparqlQueryParser();
        //    var query = parser.ParseFromString(queryInput);

        //    var triples = new TripleStore();
        //    triples.Add(RDFDatabase);

        //    var ds = new InMemoryDataset(triples, true);
        //    ISparqlQueryProcessor processor = new LeviathanQueryProcessor(ds);
        //    var results = processor.ProcessQuery(query);

        //    MessageBox.Show($"The type of the results is {results.GetType().FullName}.");

        //    if (results is SparqlResultSet srs)
        //        return srs;
        //    else throw new Exception($"The results were expected to be in SparqlResultSet format, got {results.GetType()}.");
        //}

        ///// <summary>
        ///// No database type can be saved to the file system.
        ///// </summary>
        //public static void SaveRDFDatabaseToFileSystem()
        //{
        //    var writer = new NTriplesWriter();
        //    writer.Save(RDFDatabase, "Database.tri");
        //}
    }
}
