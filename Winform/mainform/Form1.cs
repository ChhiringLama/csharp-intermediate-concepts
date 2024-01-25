using System.Drawing;
using System.Windows.Forms;
namespace mainform;

public partial class Form1 : Form
{   

    private Label  LabelCostPrice;
    private Label LabelSellPrice;
    private TextBox TextCostprice;
    private TextBox TextSellprice;
    private Button CalcButton;
    public Form1()
    {
        InitializeComponent();

        //Initialization
        LabelCostPrice=new Label();
        LabelSellPrice=new Label();
        CalcButton=new Button();

        //Add text box
         TextCostprice=new TextBox();
         TextSellprice=new TextBox();
    
        //Add them to control
        this.Controls.Add  (LabelCostPrice);
        this.Controls.Add(LabelSellPrice);
        this.Controls.Add(CalcButton);
        this.Controls.Add(TextSellprice);
        this.Controls.Add(TextCostprice);

        //Add their texts
        LabelCostPrice.Text="Cost Price";
        LabelSellPrice.Text="Selling Price";
        CalcButton.Text="Calculate";

        //Setting position and size
        LabelCostPrice.Location=new Point(20,20);
        // LabelCostPrice.Size=new Size(50,25);
        LabelSellPrice.Location=new Point(20,50);
        // LabelSellPrice.Size=new Size(50,25);

        TextCostprice.Location=new Point(190,20);
        // TextCostprice.Size=new Size(50,25);
        TextSellprice.Location=new Point(190,70);
        // TextSellprice.Size=new Size(50,25);


        CalcButton.Location=new Point(20,100);
        CalcButton.Size=new Size(100,50);
        CalcButton.Click+=CalcButtonEvent;

    }

    private void CalcButtonEvent(object sender, EventArgs e){
        int cp, sp;
        //.Text since we are accessing the text
        cp=Int32.Parse(TextCostprice.Text);
        sp=Int32.Parse(TextSellprice.Text);
        string result=(cp>sp) ? "Made loss of" +(sp-cp): "Made profit of " +(sp-cp);

        // Console.WriteLine(result);
          MessageBox.Show(result);
    }
}
