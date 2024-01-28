using System;
using System.Drawing;
using System.Windows.Forms;

// Custom delegate
public delegate void DelEventHandler();

class Program : Form
{
    // Event handler delegate, because we need delagate to be able to call multiple functions from different places 
    // regardless of classes
    public event DelEventHandler add;

    public Program()
    {
        // Design a button over form
        Button btn = new Button();
        btn.Parent = this;
        btn.Text = "Hit Me";
        btn.Location = new Point(100, 100);

        // Event handler is assigned to the button click event
        btn.Click += new EventHandler(onClick);
        add += new DelEventHandler(Initiate);

        // Invoke the event
        add();

        Controls.Add(btn); // Add the button to the form controls
    }

    // Called when the event is fired
    public void Initiate()
    {
        Console.WriteLine("Event Initiated");
    }

    // Called when the button is clicked
    public void onClick(object sender, EventArgs e)
    {
        MessageBox.Show("You clicked me");
    }

    [STAThread]
    static void Main(string[] args)
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new Program());

        Console.ReadLine();
    }
}
