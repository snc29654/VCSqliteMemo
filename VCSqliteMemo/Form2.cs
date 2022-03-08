using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VCSqliteMemo
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBox1.Font = new System.Drawing.Font("ＭＳ ゴシック", 14,
            System.Drawing.FontStyle.Bold,
            System.Drawing.GraphicsUnit.Point, 128);

            textBox1.Text = "・まず最初にテーブル作成→サンプル登録→全データ表示の順にクリックしてください。\r\n"+
                            "・次に行番セルをクリックして読み出しボタンを押下してください。\r\n"+
            "・種別と内容を記述して追加ボタンを押下すると左側表に追加されます。\r\n"+
            "・内容を変更して変更ボタンを押下すると現在のレコードが変更されます。\r\n" +
            "・種別検索は指定した種別のレコードを抽出します。\r\n" +
            "・内容検索は指定したワードが含まれた内容のレコードを抽出します。\r\n"             ;
        }
    }
}
