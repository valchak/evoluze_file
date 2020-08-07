using EvoluzeSped.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace EvoluzeSped.View
{
    public partial class FrmParametro : Form
    {
        Dictionary<string, bool> valorRegistros = new Dictionary<string, bool>();
        Parametro parametro;
        BancoLiteDB banco;
        public FrmParametro()
        {
            InitializeComponent();
            IniciaGrid();
        }


        private void IniciaGrid()
        {
            banco = new BancoLiteDB();
            parametro = new Parametro();
            parametro = banco.getParametros(parametro.Id);
            
            PopulaGrid(grid_EFD_ICMS_IP_Bloco0, parametro.Parametro_Sped_EFD_ICMS_IPI.ParametroBloco0, false);
            PopulaGrid(grid_EFD_ICMS_IP_Bloco1, parametro.Parametro_Sped_EFD_ICMS_IPI.ParametroBloco1, false);
            PopulaGrid(grid_EFD_ICMS_IP_BlocoB, parametro.Parametro_Sped_EFD_ICMS_IPI.ParametroBlocoB, false);
            PopulaGrid(grid_EFD_ICMS_IP_BlocoC, parametro.Parametro_Sped_EFD_ICMS_IPI.ParametroBlocoC, false);
            PopulaGrid(grid_EFD_ICMS_IP_BlocoD, parametro.Parametro_Sped_EFD_ICMS_IPI.ParametroBlocoD, false);
            PopulaGrid(grid_EFD_ICMS_IP_BlocoE, parametro.Parametro_Sped_EFD_ICMS_IPI.ParametroBlocoE, false);
            PopulaGrid(grid_EFD_ICMS_IP_BlocoG, parametro.Parametro_Sped_EFD_ICMS_IPI.ParametroBlocoG, false);
            PopulaGrid(grid_EFD_ICMS_IP_BlocoH, parametro.Parametro_Sped_EFD_ICMS_IPI.ParametroBlocoH, false);
            PopulaGrid(grid_EFD_ICMS_IP_BlocoK, parametro.Parametro_Sped_EFD_ICMS_IPI.ParametroBlocoK, false);
            PopulaGrid(grid_EFD_ICMS_IP_Bloco9, parametro.Parametro_Sped_EFD_ICMS_IPI.ParametroBloco9, false);

        }



        private void btnSalvar_Click(object sender, EventArgs e)
        {
            AtualziaParametroComGrid(grid_EFD_ICMS_IP_Bloco0, parametro.Parametro_Sped_EFD_ICMS_IPI.ParametroBloco0);
            AtualziaParametroComGrid(grid_EFD_ICMS_IP_Bloco1, parametro.Parametro_Sped_EFD_ICMS_IPI.ParametroBloco1);
            AtualziaParametroComGrid(grid_EFD_ICMS_IP_BlocoB, parametro.Parametro_Sped_EFD_ICMS_IPI.ParametroBlocoB);
            AtualziaParametroComGrid(grid_EFD_ICMS_IP_BlocoC, parametro.Parametro_Sped_EFD_ICMS_IPI.ParametroBlocoC);
            AtualziaParametroComGrid(grid_EFD_ICMS_IP_BlocoD, parametro.Parametro_Sped_EFD_ICMS_IPI.ParametroBlocoD);
            AtualziaParametroComGrid(grid_EFD_ICMS_IP_BlocoE, parametro.Parametro_Sped_EFD_ICMS_IPI.ParametroBlocoE);
            AtualziaParametroComGrid(grid_EFD_ICMS_IP_BlocoG, parametro.Parametro_Sped_EFD_ICMS_IPI.ParametroBlocoG);
            AtualziaParametroComGrid(grid_EFD_ICMS_IP_BlocoH, parametro.Parametro_Sped_EFD_ICMS_IPI.ParametroBlocoH);
            AtualziaParametroComGrid(grid_EFD_ICMS_IP_BlocoK, parametro.Parametro_Sped_EFD_ICMS_IPI.ParametroBlocoK);
            AtualziaParametroComGrid(grid_EFD_ICMS_IP_Bloco9, parametro.Parametro_Sped_EFD_ICMS_IPI.ParametroBloco9);

            MessageBox.Show (banco.setParametros(parametro),"Ok");
            
            IniciaGrid();

        }
        public void AtualziaParametroComGrid(DataGridView grid, object bloco)
        {
            var tipo = bloco.GetType();


            foreach (DataGridViewRow row in grid.Rows)
            {
                string chave = row.Cells[0].Value.ToString();
                bool valor = (bool) row.Cells[1].Value;
                tipo.GetProperty("Registro_" + chave).SetValue(bloco, valor);
            }

        }

        public void PopulaGrid(DataGridView grid, object bloco, bool limpaBloco)
        {
            if(bloco != null)
            {
                grid.DataSource = null;
                grid.ResetBindings();
                grid.Rows.Clear();

                int row;
                var tipo = bloco.GetType();

                PropertyInfo[] properties = tipo.GetProperties();

                foreach (var objPropertyInfo in properties)
                {
                    row = grid.Rows.Add();
                    grid.Rows[row].Cells[0].Value = objPropertyInfo.Name.Substring(9);
                    grid.Rows[row].Cells[1].Value = objPropertyInfo.GetValue(bloco);
                    grid.Rows[row].Cells[2].Value = GetInformationBloco(objPropertyInfo);


                }
            } else
            {
                foreach (DataGridViewRow row in grid.Rows)
                {
                    row.Cells[1].Value = limpaBloco;

                }
            }

            grid.Refresh();
        }

        private string GetInformationBloco(PropertyInfo objPropertyInfo)
        {
            string valor = "";

            foreach (var obj in objPropertyInfo.CustomAttributes.ToList())
            {
                if (obj.AttributeType.Name.Equals("LabelField"))
                {
                    valor = obj.ConstructorArguments[0].Value.ToString();
                    break;
                }
            }
            return valor;
        }

        private void ckLimpar_CheckedChanged(object sender, EventArgs e)
        {
            if (ckLimpar.Checked)
            {
                if (tabBloco0.CanFocus)
                    PopulaGrid(grid_EFD_ICMS_IP_Bloco0, null, true);
                if (tabBloco1.CanFocus)
                    PopulaGrid(grid_EFD_ICMS_IP_Bloco1, null, true);
                if (tabBlocoB.CanFocus)
                    PopulaGrid(grid_EFD_ICMS_IP_BlocoB, null, true);
                if (tabBlocoC.CanFocus)
                    PopulaGrid(grid_EFD_ICMS_IP_BlocoC, null, true);
                if (tabBlocoD.CanFocus)
                    PopulaGrid(grid_EFD_ICMS_IP_BlocoD, null, true);
                if (tabBlocoE.CanFocus)
                    PopulaGrid(grid_EFD_ICMS_IP_BlocoE, null, true);
                if (tabBlocoG.CanFocus)
                    PopulaGrid(grid_EFD_ICMS_IP_BlocoG, null, true);
                if (tabBlocoH.CanFocus)
                    PopulaGrid(grid_EFD_ICMS_IP_BlocoH, null, true);
                if (tabBlocoK.CanFocus)
                    PopulaGrid(grid_EFD_ICMS_IP_BlocoK, null, true);
                if (tabBloco9.CanFocus)
                    PopulaGrid(grid_EFD_ICMS_IP_Bloco9, null, true);
            }
            else
            {
                if (tabBloco0.CanFocus)
                    PopulaGrid(grid_EFD_ICMS_IP_Bloco0, null, false);
                if (tabBloco1.CanFocus)
                    PopulaGrid(grid_EFD_ICMS_IP_Bloco1, null, false);
                if (tabBlocoB.CanFocus)
                    PopulaGrid(grid_EFD_ICMS_IP_BlocoB, null, false);
                if (tabBlocoC.CanFocus)
                    PopulaGrid(grid_EFD_ICMS_IP_BlocoC, null, false);
                if (tabBlocoD.CanFocus)
                    PopulaGrid(grid_EFD_ICMS_IP_BlocoD, null, false);
                if (tabBlocoE.CanFocus)
                    PopulaGrid(grid_EFD_ICMS_IP_BlocoE, null, false);
                if (tabBlocoG.CanFocus)
                    PopulaGrid(grid_EFD_ICMS_IP_BlocoG, null, false);
                if (tabBlocoH.CanFocus)
                    PopulaGrid(grid_EFD_ICMS_IP_BlocoH, null, false);
                if (tabBlocoK.CanFocus)
                    PopulaGrid(grid_EFD_ICMS_IP_BlocoK, null, false);
                if (tabBloco9.CanFocus)
                    PopulaGrid(grid_EFD_ICMS_IP_Bloco9, null, false);
            }
        }
    }
}
