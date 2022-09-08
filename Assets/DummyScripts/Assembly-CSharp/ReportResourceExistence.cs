/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ReportResourceExistence : ReusedAudioReport // TypeDefIndex: 10987
{
	// Fields
	private readonly HashSet<uint> _validBankIds; // 0x10
	private readonly HashSet<string> _validExternalFileNames; // 0x18
	private IResourceExistenceCallbackHandler _callback; // 0x20

	// Properties
	public HashSet<uint> validBankIds { /* [XID] */ /* 0x0000000189A23E70-0x0000000189A23E90 */ get => default; } // 0x0000000183606CF0-0x0000000183606D90 
	public HashSet<string> validExternalFileNames { /* [XID] */ /* 0x0000000189A2B1E0-0x0000000189A2B200 */ get => default; } // 0x0000000183606D90-0x0000000183606E30 

	// Nested types
	public class Spawner : ISpawner<ReportResourceExistence, IResourceExistenceCallbackHandler> // TypeDefIndex: 10988
	{
		// Constructors
		public Spawner() {} // 0x0000000183603690-0x00000001836036F0

		// Methods
		// [XID] // 0x00000001897D1620-0x00000001897D1640
		public ReportResourceExistence Spawn(IResourceExistenceCallbackHandler param1) => default; // 0x00000001836035C0-0x0000000183603690
	}

	public class Polisher : IPolisher<ReportResourceExistence, IResourceExistenceCallbackHandler> // TypeDefIndex: 10989
	{
		// Constructors
		public Polisher() {} // 0x0000000183603030-0x0000000183603090

		// Methods
		// [XID] // 0x00000001897D9440-0x00000001897D9460
		public void Polish(ReportResourceExistence reused, IResourceExistenceCallbackHandler param1) {} // 0x0000000183602F60-0x0000000183603030
	}

	// Constructors
	public ReportResourceExistence() {} // Dummy constructor
	private ReportResourceExistence(IResourceExistenceCallbackHandler callback) {} // 0x0000000183606E30-0x0000000183606F20

	// Methods
	// [XID] // 0x00000001897BAB20-0x00000001897BAB40
	public override void BeforeRecycle() {} // 0x0000000183606B60-0x0000000183606C40
	// [XID] // 0x0000000189A3A1B0-0x0000000189A3A1D0
	public override void Digest(CommandThreadContext context) {} // 0x0000000183606A60-0x0000000183606B60
	// [XID] // 0x00000001897C9E80-0x00000001897C9EA0
	public override void Recycle() {} // 0x0000000183606C40-0x0000000183606CF0
}

