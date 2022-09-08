/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ReportEventCallback : ReusedAudioReport // TypeDefIndex: 10972
{
	// Fields
	private EventCallback _callback; // 0x10
	private object _cookie; // 0x18
	private AkCallbackType _callbackType; // 0x20
	private MmoronCallbackInfo _callbackInfo; // 0x28

	// Nested types
	public class Spawner : ISpawner<ReportEventCallback, EventCallback, object, AkCallbackType, MmoronCallbackInfo> // TypeDefIndex: 10973
	{
		// Constructors
		public Spawner() {} // 0x0000000182EC3C40-0x0000000182EC3CA0

		// Methods
		// [XID] // 0x00000001898EB060-0x00000001898EB080
		public ReportEventCallback Spawn(EventCallback param1, object param2, AkCallbackType param3, MmoronCallbackInfo param4) => default; // 0x0000000182EC3A30-0x0000000182EC3C40
	}

	public class Polisher : IPolisher<ReportEventCallback, EventCallback, object, AkCallbackType, MmoronCallbackInfo> // TypeDefIndex: 10974
	{
		// Constructors
		public Polisher() {} // 0x0000000182EC4200-0x0000000182EC4260

		// Methods
		// [XID] // 0x0000000189986A10-0x0000000189986A30
		public void Polish(ReportEventCallback reused, EventCallback param1, object param2, AkCallbackType param3, MmoronCallbackInfo param4) {} // 0x0000000182EC4080-0x0000000182EC4200
	}

	// Constructors
	public ReportEventCallback() {} // Dummy constructor
	private ReportEventCallback(EventCallback callback, object cookie, AkCallbackType callbackType, MmoronCallbackInfo callbackInfo) {} // 0x0000000182ECD340-0x0000000182ECD3F0

	// Methods
	// [XID] // 0x0000000189968A90-0x0000000189968AB0
	public override void BeforeRecycle() {} // 0x0000000182ECD180-0x0000000182ECD290
	// [XID] // 0x0000000189970040-0x0000000189970060
	public override void Digest(CommandThreadContext context) {} // 0x0000000182ECD050-0x0000000182ECD180
	// [XID] // 0x00000001898F2780-0x00000001898F27A0
	public override void Recycle() {} // 0x0000000182ECD290-0x0000000182ECD340
}

