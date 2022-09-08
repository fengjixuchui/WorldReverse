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

public sealed class CmdCheckResourceExistence : ReusedAudioCmd // TypeDefIndex: 10854
{
	// Fields
	private readonly List<uint> _bankIds; // 0x10
	private readonly List<string> _fileNames; // 0x18
	private IResourceExistenceCallbackHandler _callback; // 0x20

	// Properties
	public List<uint> bankIds { /* [XID] */ /* 0x0000000189970060-0x0000000189970080 */ get => default; } // 0x0000000182F4FCF0-0x0000000182F4FD90 
	public List<string> fileNames { /* [XID] */ /* 0x0000000189977EB0-0x0000000189977ED0 */ get => default; } // 0x0000000182F4FD90-0x0000000182F4FE30 

	// Nested types
	public class Spawner : ISpawner<CmdCheckResourceExistence, IResourceExistenceCallbackHandler> // TypeDefIndex: 10855
	{
		// Constructors
		public Spawner() {} // 0x0000000182F681D0-0x0000000182F68230

		// Methods
		// [XID] // 0x0000000189996100-0x0000000189996120
		public CmdCheckResourceExistence Spawn(IResourceExistenceCallbackHandler param1) => default; // 0x0000000182F68100-0x0000000182F681D0
	}

	public class Polisher : IPolisher<CmdCheckResourceExistence, IResourceExistenceCallbackHandler> // TypeDefIndex: 10856
	{
		// Constructors
		public Polisher() {} // 0x0000000182F68300-0x0000000182F68400

		// Methods
		// [XID] // 0x0000000189B40D60-0x0000000189B40D80
		public void Polish(CmdCheckResourceExistence reused, IResourceExistenceCallbackHandler param1) {} // 0x0000000182F68230-0x0000000182F68300
	}

	// Constructors
	public CmdCheckResourceExistence() {} // Dummy constructor
	private CmdCheckResourceExistence(IResourceExistenceCallbackHandler callback) {} // 0x0000000182F4FE30-0x0000000182F4FEF0

	// Methods
	// [XID] // 0x00000001896380F0-0x0000000189638110
	public override void BeforeRecycle() {} // 0x0000000182F4FB60-0x0000000182F4FC40
	// [XID] // 0x000000018963F2F0-0x000000018963F310
	public override void Execute(WorkerThreadContext context) {} // 0x0000000182F4FA70-0x0000000182F4FB60
	// [XID] // 0x000000018998E4F0-0x000000018998E510
	public override void Recycle() {} // 0x0000000182F4FC40-0x0000000182F4FCF0
}

