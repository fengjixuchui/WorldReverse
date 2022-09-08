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

public class GamePlayDirector // TypeDefIndex: 20823
{
	// Fields
	private static GamePlayDirector _instance; // 0x00
	private const string GamePlayIndexConfigPath = "QA/TestGamePlay/GamePlayIndexConfig"; // Metadata: 0x00AFE57D
	private GamePlayIndexConfig _gamePlayConfig; // 0x10
	public GamePlayLevelConfig curLevelConfig; // 0x18

	// Properties
	public static GamePlayDirector Instance { /* [XID] */ /* 0x000000018995EDF0-0x000000018995EE10 */ get => default; } // 0x000000018203DC30-0x000000018203DD10 
	public GamePlayIndexConfig gamePlayConfig { /* [XID] */ /* 0x00000001899666D0-0x00000001899666F0 */ get => default; } // 0x000000018203D900-0x000000018203DA20 

	// Constructors
	public GamePlayDirector() {} // 0x000000018203E090-0x000000018203E0F0

	// Methods
	// [XID] // 0x000000018996DA30-0x000000018996DA50
	public bool UseWhiteBox() => default; // 0x000000018203DD10-0x000000018203DE20
	// [XID] // 0x00000001899755D0-0x00000001899755F0
	public bool HasCommand() => default; // 0x000000018203DE20-0x000000018203DF30
	// [XID] // 0x000000018997C770-0x000000018997C790
	public GamePlayLevelConfig.GamePlayTmpSectorLoad GetSectorConfig(int x, int y) => default; // 0x000000018203D790-0x000000018203D900
	// [XID] // 0x00000001899844B0-0x00000001899844D0
	public void SelectConfig(int classIndex, int levelIndex) {} // 0x000000018203DA20-0x000000018203DC30
	// [XID] // 0x000000018998BF30-0x000000018998BF50
	public void AfterLoadScene() {} // 0x000000018203DF30-0x000000018203E090
}

