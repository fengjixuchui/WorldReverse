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

namespace MihoyoTools
{
	public class TerrainGrassWrapper : MonoBehaviour // TypeDefIndex: 9149
	{
		// Events
		public event EventHandlerParamInt OnClearAllGrass;
		public event EventHandlerNoParam OnPrepareEditData;
		public event EventHandlerNoParam OnClearEditData;
		public event EventHandlerNoParam OnRebuildAll;
		public event EventHandlerBrushEdit OnBrushEdit;
	
		// Nested types
		public delegate void EventHandlerParamInt(int channel); // TypeDefIndex: 9150; 0x0000000185401920-0x0000000185401AB0
	
		public delegate void EventHandlerNoParam(); // TypeDefIndex: 9151; 0x0000000185401630-0x0000000185401790
	
		public delegate void EventHandlerBrushEdit(Vector2 uv, int channel, float intensity, float range, bool inverse, bool rebuild = true /* Metadata: 0x00AE5489 */); // TypeDefIndex: 9152; 0x0000000185401210-0x00000001854014B0
	
		// Constructors
		public TerrainGrassWrapper() {} // 0x0000000185404D10-0x0000000185404D70
	
		// Methods
		// [XID] // 0x0000000189AD9B60-0x0000000189AD9B80
		public void BrushEdit(Vector2 uv, int channel, float intensity, float range, bool inverse, bool rebuild = true /* Metadata: 0x00AE5488 */) {} // 0x00000001854047F0-0x0000000185404970
		// [XID] // 0x00000001897CB560-0x00000001897CB580
		public void RebuildAll() {} // 0x0000000185404C60-0x0000000185404D10
		// [XID] // 0x0000000189AE8BD0-0x0000000189AE8BF0
		public void ClearEditData() {} // 0x0000000185404A30-0x0000000185404AE0
		// [XID] // 0x00000001896A0C80-0x00000001896A0CA0
		public void PrepareEditData() {} // 0x0000000185404BB0-0x0000000185404C60
		// [XID] // 0x0000000189AF8030-0x0000000189AF8050
		public void ClearAllGrass(int channel) {} // 0x0000000185404970-0x0000000185404A30
		// [XID] // 0x0000000189AFF5F0-0x0000000189AFF610
		public bool IsDelegateValid() => default; // 0x0000000185404AE0-0x0000000185404BB0
	}
}
