/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace MoleMole
{
	public abstract class ResourceJob : IReusable // TypeDefIndex: 7415
	{
		// Properties
		public bool finished { /* [XID] */ /* 0x000000018966D870-0x000000018966D8B0 */ get; /* [XID] */ /* 0x0000000189678670-0x00000001896786B0 */ protected set; } // 0x0000000186C41900-0x0000000186C41960 0x0000000186C419C0-0x0000000186C41A20
		public bool asyncStart { get; /* [XID] */ /* 0x000000018968A9E0-0x000000018968AA20 */ protected set; } // 0x0000000186C418A0-0x0000000186C41900 0x0000000186C41960-0x0000000186C419C0
	
		// Constructors
		protected ResourceJob() {} // 0x0000000186C41840-0x0000000186C418A0
	
		// Methods
		public abstract void Start();
		public abstract void Tick();
		public abstract void Abort(bool byUser);
		public abstract void Recycle();
		// [XID] // 0x00000001896953D0-0x00000001896953F0
		public virtual void Sync() {} // 0x0000000186C417A0-0x0000000186C41840
		// [XID] // 0x000000018969C9C0-0x000000018969C9E0
		public virtual void BeforeRecycle() {} // 0x0000000186C415F0-0x0000000186C41700
		// [XID] // 0x00000001899EE630-0x00000001899EE650
		public virtual ResourceJob PrevJob() => default; // 0x0000000186C41700-0x0000000186C417A0
	}
}
