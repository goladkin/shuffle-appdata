using System;
using System.Management.Automation;

namespace ZiyaretEt.PS.Commands
{
	[Cmdlet("Ziyaret","Et")]
	public class ZiyaretEt : PSCmdlet
	{
		[Parameter(	Position = 0,
					Mandatory = true,
					ValueFromPipelineByPropertyName = true,
					HelpMessage = "Ziyaret edebilmek için bir ağ adresi girilmelidir")]
		public string AğAdresi
		{
			get { return ağAdresi; }
			set { ağAdresi = value; }
		}
		private string ağAdresi;
		
		protected override void ProcessRecord()
		{
			
		}
	}
}