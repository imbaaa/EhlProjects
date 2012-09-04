using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SnmpSharpNet;
using System.Diagnostics;

namespace SimpleSNMP
{
    public partial class Form1 : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        public Form1()
        {
            InitializeComponent();
            this.kcbMethod.SelectedItem = "Walk";
            this.krypTxtBxOid.Text = Properties.Settings.Default.oid;
            this.ktbIPAddress.Text = Properties.Settings.Default.ip;
            //this.ktbOid.Focus();
        }

        private void kbtnGetInfo_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.oid = this.krypTxtBxOid.Text.Trim();
            Properties.Settings.Default.ip = this.ktbIPAddress.Text.Trim();
            Properties.Settings.Default.Save();

            if (krbSNMP.Checked)
            {
                SNMPGetInfo();
            }
            else
            {
                NPAGetInfo();
            }
        }

        private void NPAGetInfo()
        {
        }

        private void SNMPGetInfo()
        {
            if (this.krbSNMP.Checked)
            {
                try
                {
                    SimpleSnmp snmp = new SimpleSnmp(Properties.Settings.Default.ip, this.kcbCommunity.SelectedItem.ToString());
                    snmp.Retry = 5;
                    snmp.Timeout = 60000;
                    snmp.SuppressExceptions = false;
                    string oid = Properties.Settings.Default.oid;
                    Dictionary<Oid, AsnType> result = null;
                    if (this.kcbMethod.SelectedItem.ToString() == "Get NEXT")
                    {
                        Pdu pdu = new Pdu();
                        pdu.Type = PduType.GetNext;
                        pdu.VbList.Add(oid);
                        result = snmp.GetNext(SnmpVersion.Ver1, pdu);
                    }
                    else if (this.kcbMethod.SelectedItem.ToString() == "GET")
                    {
                        // Create a request Pdu
                        Pdu pdu = new Pdu();
                        pdu.Type = PduType.Get;
                        pdu.VbList.Add(oid);
                        result = snmp.GetNext(SnmpVersion.Ver1, pdu);
                    }
                    else if (this.kcbMethod.SelectedItem.ToString() == "Walk")
                    {
                        result = snmp.Walk(SnmpVersion.Ver2, oid);
                    }
                    else if (this.kcbMethod.SelectedItem.ToString() == "Get BULK")
                    {
                        //Using GetBulk
                        Pdu pdu = new Pdu();
                        pdu.Type = PduType.GetBulk;
                        pdu.VbList.Add(oid);
                        pdu.NonRepeaters = 0;
                        pdu.MaxRepetitions = Convert.ToInt32(this.krypTxtBxRepeaters.Text);
                        result = snmp.GetBulk(pdu);
                    }

                    ktbResult.SuspendLayout();
                    ktbResult.Clear();
                    if (result == null)
                    {
                        ktbResult.AppendText("Request failed.\r\n");
                    }
                    else
                    {
                        ktbResult.SuspendLayout();
                        foreach (KeyValuePair<Oid, AsnType> entry in result)
                        {
                            ktbResult.AppendText(String.Format("{0} = {1}: {2}\r\n", entry.Key.ToString(), SnmpConstants.GetTypeName(entry.Value.Type),
                              entry.Value.ToString()));
                        }
                        ktbResult.ResumeLayout();
                    }
                }
                catch (Exception snmpEx)
                {
                    ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show(snmpEx.Message,
                        "SNMP Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                ktbResult.Focus();
                ktbResult.SelectionStart = 0;
                ktbResult.SelectionLength = 0;
                ktbResult.ScrollToCaret();
                ktbResult.ResumeLayout();
            }
        }

        private void ktbIPAddress_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                kbtnGetInfo.PerformClick();
            }
        }

        private void ktbOid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                kbtnGetInfo.PerformClick();
            }
        }
    }
}
