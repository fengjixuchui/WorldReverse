/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine;
using UnityEngine.UI;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace StatsMonitor
{
	internal class StatsView : SMView // TypeDefIndex: 9063
	{
		// Fields
		private UnityEngine.UI.Text _text1; // 0x28
		private UnityEngine.UI.Text _text2; // 0x30
		private UnityEngine.UI.Text _text3; // 0x38
		private UnityEngine.UI.Text _text4; // 0x40
		private string[] _fpsTemplates; // 0x48
		private string _fpsMinTemplate; // 0x50
		private string _fpsMaxTemplate; // 0x58
		private string _fpsAvgTemplate; // 0x60
		private string _fxuTemplate; // 0x68
		private string _msTemplate; // 0x70
		private string _objTemplate; // 0x78
		private string _memTotalTemplate; // 0x80
		private string _memAllocTemplate; // 0x88
		private string _memMonoTemplate; // 0x90
	
		// Constructors
		public StatsView() {} // Dummy constructor
		internal StatsView(StatsMonitorWidget statsMonitorWidget) {} // 0x0000000186F3B080-0x0000000186F3B140
	
		// Methods
		// [XID] // 0x00000001899E73B0-0x00000001899E73D0
		internal override void Reset() {} // 0x0000000186F38910-0x0000000186F38A50
		// [XID] // 0x00000001898AC480-0x00000001898AC4A0
		internal override void Update() {} // 0x0000000186F39E90-0x0000000186F3B080
		// [XID] // 0x0000000189605850-0x0000000189605870
		internal override void Dispose() {} // 0x0000000186F386E0-0x0000000186F387D0
		// [XID] // 0x00000001896148A0-0x00000001896148C0
		protected override GameObject CreateChildren() => default; // 0x0000000186F383C0-0x0000000186F386E0
		// [XID] // 0x0000000189A04DE0-0x0000000189A04E00
		protected override void UpdateStyle() {} // 0x0000000186F39430-0x0000000186F39E90
		// [XID] // 0x0000000189641780-0x00000001896417A0
		protected override void UpdateLayout() {} // 0x0000000186F38CA0-0x0000000186F39430
		// [XID] // 0x0000000189650750-0x0000000189650770
		private static string PadString(string s, int minChars, int numRows) => default; // 0x0000000186F387D0-0x0000000186F38910
	}
}
