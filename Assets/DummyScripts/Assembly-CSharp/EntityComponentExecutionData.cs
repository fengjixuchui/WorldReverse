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

public class EntityComponentExecutionData // TypeDefIndex: 27823
{
	// Fields
	private static Dictionary<uint, EntityExecutionStat> entityExecutionData; // 0x00
	private static HashSet<string> components; // 0x08
	private static bool registeredCommand; // 0x10
	private static Dictionary<BaseEntity, Stack<ECPOperationHistory>> entityOperationHistory; // 0x18

	// Nested types
	public struct ECPOperationHistory // TypeDefIndex: 27824
	{
		// Fields
		public uint runtimeID; // 0x00
		public string callstack; // 0x08
		public int frameIdx; // 0x10
		public EntityManager.TickType operation; // 0x14
		public string extraInfo; // 0x18
	}

	// Constructors
	public EntityComponentExecutionData() {} // 0x00000001843E29A0-0x00000001843E2A00
	static EntityComponentExecutionData() {} // 0x00000001843E28A0-0x00000001843E29A0

	// Methods
	// [XID] // 0x000000018996EF30-0x000000018996EF50
	private static void ConditionalRegisterConsoleCommand() {} // 0x00000001843E1D70-0x00000001843E21D0
	// [XID] // 0x0000000189976AF0-0x0000000189976B10
	public static void StatEntityOperation(BaseEntity inEntity, EntityManager.TickType tickType, string extraInfo = "" /* Metadata: 0x00B0CFCE */) {} // 0x00000001843E0960-0x00000001843E0B90
	// [XID] // 0x000000018997DF50-0x000000018997DF70
	public static List<Stack<ECPOperationHistory>> GetAllHistoryByRuntimeID(uint runtimeID) => default; // 0x00000001843E0B90-0x00000001843E0EB0
	// [XID] // 0x0000000189985A70-0x0000000189985A90
	private static void StatEntity(uint configID, EntityManager.TickType tickType, int deltaFrame) {} // 0x00000001843E0F50-0x00000001843E1110
	// [XID] // 0x000000018998D650-0x000000018998D670
	public static void StatComponent(BaseComponent comp, float elapsedTime, EntityManager.TickType tickType) {} // 0x00000001843E21D0-0x00000001843E2510
	// [XID] // 0x0000000189944DD0-0x0000000189944DF0
	public static void DumpToCSV(StatLog.IBufferLogger logger, EntityManager.TickType inType, bool statEntity, bool coalsecedMode = false /* Metadata: 0x00B0CFD2 */) {} // 0x00000001843E1200-0x00000001843E1D70
}

