/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

public class MutableString // TypeDefIndex: 10076
{
	// Fields
	private static string[] _intToStr; // 0x00
	private static Pool[] _stringPool; // 0x08
	private static readonly int[] _lengthLevelCountMap; // 0x10
	private StringBuilder _sb; // 0x10
	private string _gcFreeString; // 0x18
	private bool _bEnded; // 0x20

	// Properties
	public int Capacity { get => default; } // 0x00000001853DBE50-0x00000001853DBED0 

	// Nested types
	private class Pool // TypeDefIndex: 10077
	{
		// Fields
		private LinkedList<MutableString> _allocedString; // 0x10
		private int _sbCapacity; // 0x18

		// Constructors
		public Pool() {} // Dummy constructor
		public Pool(int sbCapacity) {} // 0x00000001853E0AA0-0x00000001853E0B40

		// Methods
		private LinkedListNode<MutableString> AllocPoolMember() => default; // 0x00000001853E0820-0x00000001853E0900
		public void Alloc(ref LinkedListNode<MutableString> excludeNodeList) {} // 0x00000001853E0900-0x00000001853E09F0
		public void DisposeNode(LinkedListNode<MutableString> excludeNodeList) {} // 0x00000001853E09F0-0x00000001853E0AA0
	}

	public enum ELengthLevel // TypeDefIndex: 10078
	{
		ELL_Short = 0,
		ELL_Med = 1,
		ELL_Long = 2
	}

	// Constructors
	public MutableString() {} // Dummy constructor
	private MutableString(int maxCount) {} // 0x00000001853DBCC0-0x00000001853DBE50
	static MutableString() {} // 0x00000001853DB8A0-0x00000001853DBCC0

	// Methods
	private static int GetSBCapacityFromEnum(ELengthLevel inLengthLevel) => default; // 0x00000001853DB410-0x00000001853DB4C0
	private static int GetPoolIndexByCapacity(int capacity) => default; // 0x00000001853DB370-0x00000001853DB410
	public static void InitGlobalPool() {} // 0x00000001853DB4C0-0x00000001853DB750
	public static void FlushGlobalPool() {} // 0x00000001853DB2E0-0x00000001853DB370
	public static void Alloc(ELengthLevel inLengthLevel, ref LinkedListNode<MutableString> existingNode) {} // 0x00000001853DA750-0x00000001853DA830
	public static void DisposeNode(LinkedListNode<MutableString> existingNode) {} // 0x00000001853DB120-0x00000001853DB260
	public static MutableString Alloc(int sbCapacity) => default; // 0x00000001853DA6D0-0x00000001853DA750
	public override string ToString() => default; // 0x00000001853DB750-0x00000001853DB8A0
	private void End() {} // 0x00000001853DB260-0x00000001853DB2E0
	public void Clear() {} // 0x00000001853DB0A0-0x00000001853DB120
	public void AppendStr(string instr) {} // 0x00000001853DAF30-0x00000001853DB0A0
	private static void AppendIntRecursively(MutableString inMS, int remainValue, int maxCount = 10 /* Metadata: 0x00AE6F01 */) {} // 0x00000001853DA990-0x00000001853DAB10
	public void AppendInt(int inInt) {} // 0x00000001853DAE70-0x00000001853DAF30
	private static void AppendIntRecursively(MutableString inMS, int remainValue, int currentIndex, ref int totalCount, int decimalCount) {} // 0x00000001853DAB10-0x00000001853DAE70
	public void AppendFloat(float inFloat, int decimalCount = 2 /* Metadata: 0x00AE6F05 */) {} // 0x00000001853DA830-0x00000001853DA990
}

