﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Importador.UserControls.BaseControls
{
	public partial class UCBaseOpcao: UCBase
	{
        public UCBaseOpcao()
		{
            InitializeComponent();
		}

		public virtual void SalvarConfig() { }
	}
}
