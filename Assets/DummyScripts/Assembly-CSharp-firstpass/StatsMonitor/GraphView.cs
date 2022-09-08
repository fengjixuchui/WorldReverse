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
	internal class GraphView : SMView // TypeDefIndex: 9064
	{
		// Fields
		private RawImage _image; // 0x28
		private SMBitmap _graph; // 0x30
		private int _oldWidth; // 0x38
		private int _width; // 0x3C
		private int _height; // 0x40
		private int _graphStartX; // 0x44
		private int _graphMaxY; // 0x48
		private int _memCeiling; // 0x4C
		private int _lastGCCollectionCount; // 0x50
		private Color?[] _fpsColors; // 0x58
	
		// Constructors
		public GraphView() {} // Dummy constructor
		public GraphView(StatsMonitorWidget statsMonitorWidget) {} // 0x0000000186F1D6D0-0x0000000186F1D7A0
	
		// Methods
		// [XID] // 0x000000018965F660-0x000000018965F680
		internal override void Reset() {} // 0x0000000186F1C6B0-0x0000000186F1C780
		// [XID] // 0x0000000189A22A00-0x0000000189A22A20
		internal override void Update() {} // 0x0000000186F1D0E0-0x0000000186F1D6D0
		// [XID] // 0x00000001897C4A60-0x00000001897C4A80
		internal override void Dispose() {} // 0x0000000186F1C5E0-0x0000000186F1C6B0
		// [XID] // 0x0000000189620940-0x0000000189620960
		internal void SetWidth(float width) {} // 0x0000000186F1C780-0x0000000186F1C830
		// [XID] // 0x0000000189A38D10-0x0000000189A38D30
		protected override GameObject CreateChildren() => default; // 0x0000000186F1C310-0x0000000186F1C5E0
		// [XID] // 0x0000000189B17DC0-0x0000000189B17DE0
		protected override void UpdateStyle() {} // 0x0000000186F1CCE0-0x0000000186F1D0E0
		// [XID] // 0x0000000189A923D0-0x0000000189A923F0
		protected override void UpdateLayout() {} // 0x0000000186F1CA80-0x0000000186F1CCE0
	}
}
