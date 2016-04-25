using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FastColoredTextBoxNS;
using System.Management.Automation;
using System.Management.Automation.Runspaces;
using System.Collections.ObjectModel;

namespace BoinEditNS {
    public partial class PowerShellConsole : FastColoredTextBox {

        Runspace runspace;
        Pipeline pipeline;

        public PowerShellConsole() {
            
            
            runspace = RunspaceFactory.CreateRunspace();
            runspace.Open();

            pipeline = runspace.CreatePipeline(this.Text);

            Collection<PSObject> output = pipeline.Invoke();

            foreach (PSObject obj in output) {
                this.AppendText(obj.ToString() + "\r\n");
            }
        }
    }
}
