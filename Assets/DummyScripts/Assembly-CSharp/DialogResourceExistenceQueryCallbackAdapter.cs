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

public class DialogResourceExistenceQueryCallbackAdapter : IResourceExistenceCallbackHandler // TypeDefIndex: 11391
{
	// Fields
	private readonly Dictionary<uint, string> _dialogIdToVoiceFileMap; // 0x10
	private readonly List<string> _externalVoiceFileNames; // 0x18
	private readonly HashSet<uint> _resourceReadyDialogIds; // 0x20
	private IDialogResourceExistenceQueryCallbackHandler _actualHandler; // 0x28

	// Properties
	public Dictionary<uint, string> dialogIdToVoiceFileMap { /* [XID] */ /* 0x000000018998FD40-0x000000018998FD60 */ get => default; } // 0x00000001830BF4C0-0x00000001830BF560 
	public List<string> externalVoiceFileNames { /* [XID] */ /* 0x0000000189997650-0x0000000189997670 */ get => default; } // 0x00000001830BF890-0x00000001830BF930 

	// Nested types
	public class Spawner : ISpawner<DialogResourceExistenceQueryCallbackAdapter, IDialogResourceExistenceQueryCallbackHandler> // TypeDefIndex: 11392
	{
		// Constructors
		public Spawner() {} // 0x00000001830E0920-0x00000001830E0980

		// Methods
		// [XID] // 0x00000001898DA210-0x00000001898DA230
		public DialogResourceExistenceQueryCallbackAdapter Spawn(IDialogResourceExistenceQueryCallbackHandler param1) => default; // 0x00000001830E0850-0x00000001830E0920
	}

	public class Polisher : IPolisher<DialogResourceExistenceQueryCallbackAdapter, IDialogResourceExistenceQueryCallbackHandler> // TypeDefIndex: 11393
	{
		// Constructors
		public Polisher() {} // 0x00000001830E0D10-0x00000001830E0EC0

		// Methods
		// [XID] // 0x00000001899C4CF0-0x00000001899C4D10
		public void Polish(DialogResourceExistenceQueryCallbackAdapter reused, IDialogResourceExistenceQueryCallbackHandler param1) {} // 0x00000001830E0C40-0x00000001830E0D10
	}

	// Constructors
	public DialogResourceExistenceQueryCallbackAdapter() {} // Dummy constructor
	private DialogResourceExistenceQueryCallbackAdapter(IDialogResourceExistenceQueryCallbackHandler actualHandler) {} // 0x00000001830BF930-0x00000001830BFA10

	// Methods
	// [XID] // 0x00000001898BC410-0x00000001898BC430
	public void Invoke(HashSet<uint> bankResults, HashSet<string> externalFileResults) {} // 0x00000001830BF790-0x00000001830BF890
	// [XID] // 0x00000001899A6C10-0x00000001899A6C30
	public void BeforeRecycle() {} // 0x00000001830BF310-0x00000001830BF400
	// [XID] // 0x00000001898D28E0-0x00000001898D2900
	public void Recycle() {} // 0x00000001830BF400-0x00000001830BF4C0
	// [XID] // 0x00000001898C37B0-0x00000001898C37D0
	private void PickResourceReadyDialogIds(HashSet<string> confirmedVoiceFiles) {} // 0x00000001830BF560-0x00000001830BF790
}

