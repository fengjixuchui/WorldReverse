/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class CmdUpdateSyncTransform : ReusedAudioCmd // TypeDefIndex: 10926
{
	// Fields
	private SyncId _syncId; // 0x10
	private Vector3 _position; // 0x28
	private Quaternion _rotation; // 0x34

	// Nested types
	public class Spawner : ISpawner<CmdUpdateSyncTransform, SyncId, Vector3, Quaternion> // TypeDefIndex: 10927
	{
		// Constructors
		public Spawner() {} // 0x00000001811BF010-0x00000001811BF070

		// Methods
		// [XID] // 0x000000018971BB30-0x000000018971BB50
		public CmdUpdateSyncTransform Spawn(SyncId param1, Vector3 param2, Quaternion param3) => default; // 0x00000001811BEE50-0x00000001811BF010
	}

	public class Polisher : IPolisher<CmdUpdateSyncTransform, SyncId, Vector3, Quaternion> // TypeDefIndex: 10928
	{
		// Constructors
		public Polisher() {} // 0x00000001811DCE70-0x00000001811DCED0

		// Methods
		// [XID] // 0x0000000189722EB0-0x0000000189722ED0
		public void Polish(CmdUpdateSyncTransform reused, SyncId param1, Vector3 param2, Quaternion param3) {} // 0x00000001811DCD10-0x00000001811DCE70
	}

	// Constructors
	public CmdUpdateSyncTransform() {} // Dummy constructor
	private CmdUpdateSyncTransform(SyncId syncId, Vector3 position, Quaternion rotation) {} // 0x00000001811C2920-0x00000001811C29E0

	// Methods
	// [XID] // 0x00000001897051B0-0x00000001897051D0
	public override void BeforeRecycle() {} // 0x00000001811C2720-0x00000001811C2870
	// [XID] // 0x00000001898B0380-0x00000001898B03A0
	public override void Execute(WorkerThreadContext context) {} // 0x00000001811C25F0-0x00000001811C2720
	// [XID] // 0x0000000189714130-0x0000000189714150
	public override void Recycle() {} // 0x00000001811C2870-0x00000001811C2920
}

