/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class EntityDebugMonitor // TypeDefIndex: 27715
{
	// Fields
	private static EntityAppearTimer _timer; // 0x00
	private static EntityAppearInfo _entityAppearInfo; // 0x08
	private static EntityAppearInfo _entityDisappearInfo; // 0x10

	// Nested types
	public class EntityAppearCountInfo // TypeDefIndex: 27716
	{
		// Fields
		public int entityAppearCount; // 0x10
		public int maxEntityAppearCount; // 0x14
		public bool isLoading; // 0x18
		public bool isAsync; // 0x19

		// Constructors
		public EntityAppearCountInfo() {} // 0x00000001836EB760-0x00000001836EB7C0
	}

	public class EntityAppearInfo // TypeDefIndex: 27717
	{
		// Fields
		private EntityAppearCountInfo _info; // 0x10
		private EntityAppearCountInfo _infoByTimer; // 0x18
		private EntityAppearCountInfo _infoCounter; // 0x20
		private bool _timerDirty; // 0x28
		private bool _infoDirty; // 0x29
		private bool _counterDirty; // 0x2A

		// Properties
		public EntityAppearCountInfo countInfo { /* [XID] */ /* 0x0000000189702C10-0x0000000189702C30 */ get => default; } // 0x00000001836EBE90-0x00000001836EBF30 

		// Constructors
		public EntityAppearInfo() {} // 0x00000001836EC020-0x00000001836EC1A0

		// Methods
		// [XID] // 0x000000018970A350-0x000000018970A370
		public bool IsValid() => default; // 0x00000001836EB940-0x00000001836EBA00
		// [XID] // 0x0000000189711EB0-0x0000000189711ED0
		public void UpdateTimer(bool force) {} // 0x00000001836EBAC0-0x00000001836EBD70
		// [XID] // 0x00000001897193B0-0x00000001897193D0
		public void ResetDirty() {} // 0x00000001836EBF30-0x00000001836EC020
		// [XID] // 0x0000000189720930-0x0000000189720950
		public void UpdateEntityAppear(bool async, int count) {} // 0x00000001836EBD70-0x00000001836EBE90
		// [XID] // 0x0000000189727F00-0x0000000189727F20
		private void ResetEntityAppearCount() {} // 0x00000001836EBA00-0x00000001836EBAC0
	}

	private class EntityAppearTimer : DebugMonitorTimer // TypeDefIndex: 27718
	{
		// Constructors
		public EntityAppearTimer() {} // 0x00000001836EB8E0-0x00000001836EB940

		// Methods
		// [XID] // 0x000000018972F5F0-0x000000018972F610
		public override void Update(bool overtime) {} // 0x00000001836EB7C0-0x00000001836EB8E0
	}

	// Constructors
	public EntityDebugMonitor() {} // 0x00000001836CE0B0-0x00000001836CE110
	static EntityDebugMonitor() {} // 0x00000001836CDFA0-0x00000001836CE0B0

	// Methods
	// [XID] // 0x00000001896AA380-0x00000001896AA3A0
	private static bool EntityAppearIsValid() => default; // 0x00000001836CCD90-0x00000001836CCED0
	// [XID] // 0x00000001896B11A0-0x00000001896B11C0
	private static void ResetEntityAppearDirty() {} // 0x00000001836CD160-0x00000001836CD260
	// [XID] // 0x00000001896B8D30-0x00000001896B8D50
	public static void UpdateEntityAppear(bool async, int count) {} // 0x00000001836CD950-0x00000001836CDA50
	// [XID] // 0x00000001896BFF30-0x00000001896BFF50
	public static void UpdateEntityDisappear(bool async, int count) {} // 0x00000001836CCED0-0x00000001836CCFD0
	// [XID] // 0x00000001896C7830-0x00000001896C7850
	public static bool EntityAppiearIsAsync() => default; // 0x00000001836CDC80-0x00000001836CDE10
	// [XID] // 0x00000001896CF010-0x00000001896CF030
	public static bool EntityAppiearIsLoading() => default; // 0x00000001836CDE10-0x00000001836CDFA0
	// [XID] // 0x00000001896D63D0-0x00000001896D63F0
	public static void Tick() {} // 0x00000001836CD260-0x00000001836CD330
	// [XID] // 0x00000001896DDA50-0x00000001896DDA70
	public static string GetEntityType(BaseEntity entity, string entityName) => default; // 0x00000001836CCFD0-0x00000001836CD160
	// [XID] // 0x00000001896E5120-0x00000001896E5140
	public static string GetEntityList(string type) => default; // 0x00000001836CC8A0-0x00000001836CCD90
	// [XID] // 0x00000001896EC5A0-0x00000001896EC5C0
	public static void GetEntityAppearInfo() {} // 0x00000001836CD6B0-0x00000001836CD950
	// [XID] // 0x00000001896F3D70-0x00000001896F3D90
	public static string GetEntityAppearInfoString() => default; // 0x00000001836CDA50-0x00000001836CDC80
	// [XID] // 0x00000001896FB5C0-0x00000001896FB5E0
	public static void AddEntityAppearInfo(StringBuilder buffer) {} // 0x00000001836CD330-0x00000001836CD6B0
}

