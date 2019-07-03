using System;
using System.Windows.Forms;
//using VDS.RDF;
//using VDS.RDF.Query;
//using VDS.RDF.Parsing;
//using VDS.RDF.Query.Datasets;
//using VDS.RDF.Writing.Formatting;

namespace Hotelogram
{
    public partial class FQueryDatabase : Form
    {
        public FQueryDatabase()
        {
            InitializeComponent();
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonQuery_Click(object sender, EventArgs e)
        {
            //if (string.IsNullOrEmpty(TextBoxInput.Text))
            //{
            //    MessageBox.Show("Please enter a query.", "Hotelogram", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}

            //try
            //{
            //    var parser = new SparqlQueryParser();
            //    var query = parser.ParseFromString(TextBoxInput.Text);
                
            //    var triples = new TripleStore();
            //    triples.Add(Database.RDFDatabase);

            //    var ds = new InMemoryDataset(triples, true);
            //    ISparqlQueryProcessor processor = new LeviathanQueryProcessor(ds);
            //    var results = processor.ProcessQuery(query);

            //    MessageBox.Show($"The type of the results is {results.GetType().FullName}.");

            //    switch (results)
            //    {
            //        case IGraph g:
            //        {
            //            //Print out the Results
            //            var formatter = new NTriplesFormatter();

            //            TextBoxOutput.Clear();

            //            foreach (var t in g.Triples)
            //            {
            //                TextBoxOutput.AppendText(t.ToString(formatter) + Environment.NewLine);
            //            }

            //            break;
            //        }

            //        case SparqlResultSet srs:
            //            TextBoxOutput.Clear();

            //            foreach (var result in srs)
            //                TextBoxOutput.AppendText(result + Environment.NewLine);
            //            break;

            //        default:
            //            MessageBox.Show("An error occurred or the results are in an unknown format, therefore they cannot be displayed.", "Hotelogram", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //            break;
            //    }
            //}
            //catch (RdfParseException rpe)
            //{
            //    MessageBox.Show($"The query you have entered is not a valid query:{Environment.NewLine}{rpe.Message}{Environment.NewLine}Please edit your query and try again.", "Hotelogram", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }
    }
}
