namespace MediaAlunos
{
    public partial class Form1 : Form{
        public Form1(){
            InitializeComponent();
        }

        public void Calcular(){
            try
            {
                decimal n1,n2,n3,n4,maiorNota,menorNota,media;

                n1 = Convert.ToDecimal(txtN1.Text);
                n2 = Convert.ToDecimal(txtN2.Text);
                n3 = Convert.ToDecimal(txtN3.Text);
                n4 = Convert.ToDecimal(txtN4.Text);
                maiorNota = Convert.ToDecimal(IsTextValidated(lblMaiorNota.Text));
                menorNota = Convert.ToDecimal(IsTextValidated(lblMenorNota.Text));
                media = Convert.ToDecimal(lblMedia.Text);

                if(n1>n2 && n1>n3 && n1>n4){
                    maiorNota = n1;
                }else if(n2>n1 && n2>n3 && n2>n4){
                    maiorNota = n2;
                }else if(n3>n1 && n3>n2 && n3>n4){
                    maiorNota = n3;
                }else{
                    maiorNota = n4;
                }

                if(n1<n2 && n1<n3 && n1<n4){
                    menorNota = n1;
                }else if(n2<n1 && n2<n3 && n2<n4){
                    menorNota = n2;
                }else if(n3<n1 && n3<n2 && n3<n4){
                    menorNota = n3;
                }else{
                    menorNota = n4;
                }

                lblMaiorNota.Text = maiorNota.ToString();
                lblMenorNota = menorNota.ToString();

                media = (n1+n2+n3+n4)/4;
                lblMedia.Text = media.ToString();
                
            }

            catch (FormatException){
                MessageBox.Show("Digite números de 0 a 10","Mensagem do Sitemas");
            }
    }
}

private bool IsTextValidated(string strTextEntry){
    Regex objNotWholePattern = new Regex("[^0-9]");
    return !objNotWholePattern.IsMatch(strTextEntry);
}

public void Limpar(){
    txtN1.Text = "";
    txtN2.Text = "";
    txtN3.Text = "";
    txtN4.Text = "";
    lblMaiorNota.Text = "";
    lblMenorNota.Text = "";
    lblMedia.Text = "";
    lblResultado.Text = "";
}

public void Sair(){
    DialogResult result;
    result = MessageBox.Show("Tem certeza que deseja sair?","Mensagem", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

    if(result == System.Windows.Forms.DialogResult.Yes){
        this.Close();
    }
}

private void txtN1_KeyPress(object sender, KewPressEventArgs e){
    if(!(char.IsDigit(e.KeyChar))){
        e.Handled = true;
    }

    if(e.KeyChar == 8 || e.KeyChar == 44){
        e.Handled = false;
    }
}

private void txtN2_KeyPress(object sender, KewPressEventArgs e){
    if(!(char.IsDigit(e.KeyChar))){
        e.Handled = true;
    }

    if(e.KeyChar == 8 || e.KeyChar == 44){
        e.Handled = false;
    }
}

private void txtN3_KeyPress(object sender, KewPressEventArgs e){
    if(!(char.IsDigit(e.KeyChar))){
        e.Handled = true;
    }

    if(e.KeyChar == 8 || e.KeyChar == 44){
        e.Handled = false;
    }
}

private void txtN4_KeyPress(object sender, KewPressEventArgs e){
    if(!(char.IsDigit(e.KeyChar))){
        e.Handled = true;
    }

    if(e.KeyChar == 8 || e.KeyChar == 44){
        e.Handled = false;
    }
}

private void btnCalcular_Click(object sender, EventArgs e){
    Calcular();
}

private void btnLimpar_Click(object sender, EventArgs e){
    Limpar();
}

private void btnSair_Click(object sender, EventArgs e){
    Sair();
}
}