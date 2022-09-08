/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace StatsMonitor
{
	internal abstract class SMView // TypeDefIndex: 9061
	{
		// Fields
		internal GameObject gameObject; // 0x10
		private RectTransform _rectTransform; // 0x18
		protected StatsMonitorWidget _statsMonitorWidget; // 0x20
	
		// Properties
		internal RectTransform RTransform { /* [XID] */ /* 0x0000000189B74610-0x0000000189B74630 */ get; } // 0x0000000186F23EC0-0x0000000186F24020 
		internal float Width { /* [XID] */ /* 0x0000000189905FB0-0x0000000189905FD0 */ get; /* [XID] */ /* 0x000000018990D960-0x000000018990D980 */ set; } // 0x0000000186F24020-0x0000000186F24120 0x0000000186F24600-0x0000000186F246D0
		internal float Height { /* [XID] */ /* 0x0000000189915070-0x0000000189915090 */ get; /* [XID] */ /* 0x000000018991CC90-0x000000018991CCB0 */ set; } // 0x0000000186F23CF0-0x0000000186F23DF0 0x0000000186F24460-0x0000000186F24530
		internal float X { /* [XID] */ /* 0x0000000189924620-0x0000000189924640 */ get; /* [XID] */ /* 0x000000018992BA10-0x000000018992BA30 */ set; } // 0x0000000186F24120-0x0000000186F241F0 0x0000000186F246D0-0x0000000186F247D0
		internal float Y { /* [XID] */ /* 0x0000000189A2BFF0-0x0000000189A2C010 */ get; /* [XID] */ /* 0x00000001899FFB20-0x00000001899FFB40 */ set; } // 0x0000000186F241F0-0x0000000186F242C0 0x0000000186F247D0-0x0000000186F248D0
		internal Vector2 Pivot { /* [XID] */ /* 0x0000000189941B50-0x0000000189941B70 */ get; /* [XID] */ /* 0x00000001899496D0-0x00000001899496F0 */ set; } // 0x0000000186F23DF0-0x0000000186F23EC0 0x0000000186F24530-0x0000000186F24600
		internal Vector2 AnchorMin { /* [XID] */ /* 0x0000000189950EB0-0x0000000189950ED0 */ get; /* [XID] */ /* 0x0000000189B29A20-0x0000000189B29A40 */ set; } // 0x0000000186F23C20-0x0000000186F23CF0 0x0000000186F24390-0x0000000186F24460
		internal Vector2 AnchorMax { /* [XID] */ /* 0x0000000189B386B0-0x0000000189B386D0 */ get; /* [XID] */ /* 0x0000000189967640-0x0000000189967660 */ set; } // 0x0000000186F23B50-0x0000000186F23C20 0x0000000186F242C0-0x0000000186F24390
	
		// Constructors
		protected SMView() {} // 0x0000000186F23AF0-0x0000000186F23B50
	
		// Methods
		// [XID] // 0x000000018996E850-0x000000018996E870
		internal void SetScale(float h = 1f /* Metadata: 0x00AE51BF */, float v = 1f /* Metadata: 0x00AE51C3 */) {} // 0x0000000186F237E0-0x0000000186F23910
		// [XID] // 0x0000000189B658A0-0x0000000189B658C0
		internal void SetRTransformValues(float x, float y, float width, float height, Vector2 pivotAndAnchor) {} // 0x0000000186F23600-0x0000000186F237E0
		// [XID] // 0x0000000189778FC0-0x0000000189778FE0
		internal void Invalidate(SMViewInvalidationType type = SMViewInvalidationType.All /* Metadata: 0x00AE51C7 */) {} // 0x0000000186F23350-0x0000000186F23560
		// [XID] // 0x000000018999D710-0x000000018999D730
		internal virtual void Reset() {} // 0x0000000186F23560-0x0000000186F23600
		// [XID] // 0x000000018998CDE0-0x000000018998CE00
		internal virtual void Update() {} // 0x0000000186F23A50-0x0000000186F23AF0
		// [XID] // 0x0000000189994A80-0x0000000189994AA0
		internal virtual void Dispose() {} // 0x0000000186F232A0-0x0000000186F23350
		// [XID] // 0x000000018999C340-0x000000018999C360
		internal static void Destroy(UnityEngine.Object obj) {} // 0x0000000186F231E0-0x0000000186F232A0
		// [XID] // 0x0000000189787E80-0x0000000189787EA0
		protected virtual GameObject CreateChildren() => default; // 0x0000000186F23140-0x0000000186F231E0
		// [XID] // 0x00000001899AB870-0x00000001899AB890
		protected virtual void UpdateStyle() {} // 0x0000000186F239B0-0x0000000186F23A50
		// [XID] // 0x00000001899B3110-0x00000001899B3130
		protected virtual void UpdateLayout() {} // 0x0000000186F23910-0x0000000186F239B0
	}
}
