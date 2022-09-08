/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using IFix.Core;
using MoleMole;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class CommandThreadQuestFunctionalities : CommandThreadFunctionalities<SharedQuestFunctionalities> // TypeDefIndex: 11388
{
	// Fields
	private readonly PotentialPatrollers<VCMonsterAudio> _monsters; // 0x20
	private readonly PotentialPatrollers<VCNpcAudio> _npcs; // 0x28
	private readonly List<AudioPatrollerPlugin> _arousedPatrollers; // 0x30

	// Properties
	public PotentialPatrollers<VCMonsterAudio> monsterPatrollers { /* [XID] */ /* 0x00000001897D7A20-0x00000001897D7A40 */ get => default; } // 0x000000018209A230-0x000000018209A2D0 
	public PotentialPatrollers<VCNpcAudio> npcPatrollers { /* [XID] */ /* 0x00000001898E6410-0x00000001898E6430 */ get => default; } // 0x000000018209AA10-0x000000018209AAB0 

	// Nested types
	public class PotentialPatrollers // TypeDefIndex: 11389
	{
		// Properties
		public static bool shouldEvolve { get; /* [XID] */ /* 0x0000000189985120-0x0000000189985160 */ set; } // 0x000000018207EC40-0x000000018207ECA0 0x000000018207ECA0-0x000000018207ED00

		// Constructors
		public PotentialPatrollers() {} // 0x000000018207ED00-0x000000018207ED80
	}

	public class PotentialPatrollers<T> : PotentialPatrollers // TypeDefIndex: 11390
		where T : VCBaseAudio, IAudioPotentialPatroller
	{
		// Fields
		private readonly HashSet<T> _instances;

		// Constructors
		public PotentialPatrollers() {}

		// Methods
		public void ReportInstanceCreated(T instance) {}
		public void ReportInstanceDestroyed(T instance) {}
		public void Evolve() {}
		public void Devolve() {}
	}

	// Constructors
	public CommandThreadQuestFunctionalities() {} // Dummy constructor
	public CommandThreadQuestFunctionalities(CommandThreadContext context, SharedQuestFunctionalities shared) {} // 0x000000018209AB60-0x000000018209AC50

	// Methods
	// [XID] // 0x00000001897DEE90-0x00000001897DEEB0
	public override void Init() {} // 0x0000000182099D30-0x0000000182099DD0
	// [XID] // 0x00000001897E6960-0x00000001897E6980
	public override void Tick(float deltaTime) {} // 0x0000000182099DD0-0x0000000182099F00
	// [XID] // 0x00000001898FCDA0-0x00000001898FCDC0
	public override void EnterHomeWorld(bool firstTime) {} // 0x000000018209A180-0x000000018209A230
	// [XID] // 0x0000000189904740-0x0000000189904760
	public override void ExitHomeWorld() {} // 0x000000018209A490-0x000000018209A530
	// [XID] // 0x000000018990BF00-0x000000018990BF20
	public override void ExitGameWorld() {} // 0x000000018209A3F0-0x000000018209A490
	// [XID] // 0x000000018980A910-0x000000018980A930
	public override void CreateLevel() {} // 0x0000000182099950-0x00000001820999F0
	// [XID] // 0x000000018991B240-0x000000018991B260
	public override void EnterLevel() {} // 0x000000018209A010-0x000000018209A0B0
	// [XID] // 0x0000000189922810-0x0000000189922830
	public override void ExitLevel() {} // 0x0000000182099C80-0x0000000182099D30
	// [XID] // 0x0000000189929F80-0x0000000189929FA0
	public override void DumpCriticalInfo(StringBuilder builder) {} // 0x000000018209AAB0-0x000000018209AB60
	// [XID] // 0x00000001897B8FA0-0x00000001897B8FC0
	public override void Destroy() {} // 0x0000000182099B10-0x0000000182099BB0
	// [XID] // 0x0000000189938DA0-0x0000000189938DC0
	public void RespondToQuestStatusChange(QuestProxy questProxy) {} // 0x0000000182099F00-0x000000018209A010
	// [IDTag] // 0x0000000189940570-0x00000001899405B0
	// [XID] // 0x0000000189940570-0x00000001899405B0
	public void QueryDialogResourceExistence(IEnumerable<uint> dialogOrReminderIds, DialogResourceExistenceCallback callback) {} // 0x000000018209A900-0x000000018209AA10
	// [IDTag] // 0x000000018994AB80-0x000000018994ABC0
	// [XID] // 0x000000018994AB80-0x000000018994ABC0
	public void QueryDialogResourceExistence(IEnumerable<uint> dialogOrReminderIds, IDialogResourceExistenceQueryCallbackHandler callbackHandler) {} // 0x000000018209A530-0x000000018209A900
	// [XID] // 0x00000001899551C0-0x00000001899551E0
	public void AddPatrollerPluginsToMonstersAndNpcs() {} // 0x00000001820999F0-0x0000000182099B10
	// [XID] // 0x00000001898A5C70-0x00000001898A5C90
	public void RemovePatrollerPluginsFromMonstersAndNpcs() {} // 0x000000018209A2D0-0x000000018209A3F0
	// [XID] // 0x00000001899642B0-0x00000001899642D0
	public void MarkPatrollerAroused(AudioPatrollerPlugin patroller) {} // 0x000000018209A0B0-0x000000018209A180
	// [XID] // 0x000000018996B910-0x000000018996B930
	public void MarkPatrollerTranquilized(AudioPatrollerPlugin patroller) {} // 0x0000000182099BB0-0x0000000182099C80
}

