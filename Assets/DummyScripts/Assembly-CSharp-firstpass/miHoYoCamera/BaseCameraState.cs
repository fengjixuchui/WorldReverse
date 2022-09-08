/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace miHoYoCamera
{
	public class BaseCameraState : ICameraState // TypeDefIndex: 8949
	{
		// Fields
		protected int _id; // 0x10
		protected int _type; // 0x14
		protected int _priority; // 0x18
		protected string _name; // 0x20
		protected string _description; // 0x28
		protected bool _isSpawned; // 0x30
		protected CameraStateData _data; // 0x38
		protected bool _isBackground; // 0x110
		protected ICameraStateRunner _runner; // 0x118
	
		// Properties
		public int Id { /* [XID] */ /* 0x00000001897606B0-0x00000001897606D0 */ get => default; } // 0x0000000185A706C0-0x0000000185A70760 
		public int Type { /* [XID] */ /* 0x0000000189767A50-0x0000000189767A70 */ get => default; } // 0x0000000185A70AA0-0x0000000185A70B40 
		public int Priority { /* [XID] */ /* 0x0000000189A9ECE0-0x0000000189A9ED00 */ get => default; } // 0x0000000185A70950-0x0000000185A709F0 
		public string Name { /* [XID] */ /* 0x0000000189776B60-0x0000000189776B80 */ get => default; } // 0x0000000185A708B0-0x0000000185A70950 
		public virtual string Description { /* [XID] */ /* 0x0000000189B9B490-0x0000000189B9B4B0 */ get => default; } // 0x0000000185A70620-0x0000000185A706C0 
		public bool IsSpawned { /* [XID] */ /* 0x00000001899E0460-0x00000001899E0480 */ get => default; } // 0x0000000185A70810-0x0000000185A708B0 
		public CameraStateData Data { /* [XID] */ /* 0x0000000189A3AA60-0x0000000189A3AA80 */ get => default; } // 0x0000000185A703C0-0x0000000185A70620 
		public bool IsBackground { /* [XID] */ /* 0x00000001895EEEA0-0x00000001895EEEC0 */ get => default; } // 0x0000000185A70760-0x0000000185A70810 
		public virtual CameraStateBlenderConfig BlendCfg { /* [XID] */ /* 0x00000001895F68E0-0x00000001895F6900 */ get => default; } // 0x0000000185A70320-0x0000000185A703C0 
		public ICameraStateRunner Runner { /* [XID] */ /* 0x00000001895E75D0-0x00000001895E75F0 */ get => default; } // 0x0000000185A709F0-0x0000000185A70AA0 
	
		// Constructors
		public BaseCameraState() {} // 0x0000000185A701C0-0x0000000185A70320
	
		// Methods
		// [XID] // 0x00000001895F2940-0x00000001895F2960
		public void InitState(int id, int type, int priority, string name, string desc) {} // 0x0000000185A6F700-0x0000000185A6F810
		// [XID] // 0x0000000189940C80-0x0000000189940CA0
		public void Spawn() {} // 0x0000000185A6FC80-0x0000000185A6FD30
		// [XID] // 0x000000018981A480-0x000000018981A4A0
		protected virtual void OnSpawn() {} // 0x0000000185A6FA90-0x0000000185A6FB30
		// [XID] // 0x00000001898D1A10-0x00000001898D1A30
		public void UnSpawn() {} // 0x0000000185A6FDE0-0x0000000185A6FE90
		// [XID] // 0x0000000189A33150-0x0000000189A33170
		protected virtual void OnUnSpawn() {} // 0x0000000185A6FB30-0x0000000185A6FBD0
		// [XID] // 0x0000000189BD62A0-0x0000000189BD62C0
		public void UpdateData(CameraStateData data) {} // 0x0000000185A6FFF0-0x0000000185A701C0
		// [XID] // 0x0000000189BDACC0-0x0000000189BDACE0
		public virtual void SwitchBackground(bool value) {} // 0x0000000185A6FD30-0x0000000185A6FDE0
		// [XID] // 0x00000001895FDCA0-0x00000001895FDCC0
		public virtual void RegisterRunner(ICameraStateRunner runner) {} // 0x0000000185A6FBD0-0x0000000185A6FC80
		// [XID] // 0x00000001897E7DF0-0x00000001897E7E10
		public virtual void UpdateByState(ICameraState state) {} // 0x0000000185A6FF40-0x0000000185A6FFF0
		// [XID] // 0x00000001899755F0-0x0000000189975610
		public virtual void UpdateByBlendSrc(ICameraState state) {} // 0x0000000185A6FE90-0x0000000185A6FF40
		// [XID] // 0x00000001897F71A0-0x00000001897F71C0
		public virtual void Collect() {} // 0x0000000185A6F5B0-0x0000000185A6F650
		// [XID] // 0x000000018998BF70-0x000000018998BF90
		public virtual void OnBlendToStart() {} // 0x0000000185A6F9F0-0x0000000185A6FA90
		// [XID] // 0x0000000189923300-0x0000000189923320
		public virtual void OnBlendFromStart() {} // 0x0000000185A6F8B0-0x0000000185A6F950
		// [XID] // 0x000000018980D6A0-0x000000018980D6C0
		public virtual void OnBlendToFinished() {} // 0x0000000185A6F950-0x0000000185A6F9F0
		// [XID] // 0x00000001897920E0-0x0000000189792100
		public virtual void OnBlendFromFinished() {} // 0x0000000185A6F810-0x0000000185A6F8B0
		// [XID] // 0x000000018978AA40-0x000000018978AA60
		public virtual void Dispose() {} // 0x0000000185A6F650-0x0000000185A6F700
	}
}
