using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utils;

namespace LAUNCHR
{
    public partial class Error : Form
    {
        public Error(Exception ex)
        {
            InitializeComponent();
            notifyError(ex);
        }

        private void notifyError(Exception ex)
        {
            StringBuilder stringBuilderCorpo = new StringBuilder(1000);

            stringBuilderCorpo.Append("<b>Atenação!!</b>");
            stringBuilderCorpo.Append("<br />");
            stringBuilderCorpo.Append("<br />");
            stringBuilderCorpo.Append("Ocorreu um erro no sistema em tempo de execução.");
            stringBuilderCorpo.Append("<br />");
            stringBuilderCorpo.Append("Segue abaixo os dados do erro:");
            stringBuilderCorpo.Append("<br />");
            stringBuilderCorpo.Append("<br />");
            stringBuilderCorpo.Append("<b>Data/hora que ocorreu o erro:</b> ");
            stringBuilderCorpo.Append(DateTime.Now.ToString("dd/MM/yyyy 'às' HH:mm:ss"));
            stringBuilderCorpo.Append("<br />");
            stringBuilderCorpo.Append("<b>Erro ocorrido:</b> ");
            stringBuilderCorpo.Append(ex.Message);
            stringBuilderCorpo.Append("<br />");
            stringBuilderCorpo.Append("<b>Stack do erro:</b> ");
            stringBuilderCorpo.Append(ex.StackTrace);
            stringBuilderCorpo.Append("<br />");
            stringBuilderCorpo.Append("<b>Source:</b> ");
            stringBuilderCorpo.Append(ex.Source);
            stringBuilderCorpo.Append("<br />");
            stringBuilderCorpo.Append("<br />");
            stringBuilderCorpo.Append("Atenciosamente,<br />Equipe administrativa<br /><br />");
            stringBuilderCorpo.Append("<b>Atenção. Se você recebeu este email por engano, por favor desconsidere-o.</b>");

            Email email = new Email();

            email.assunto = "Erro na aplicação de chamados";
            email.destinatario = "expeors@gmail.com";
            email.corpo = stringBuilderCorpo.ToString();

            ClienteEmail.sendEmail(email);
        }

    }
}
