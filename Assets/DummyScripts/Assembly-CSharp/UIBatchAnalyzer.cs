/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using UnityEngine;
using UnityEngine.UI;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class UIBatchAnalyzer // TypeDefIndex: 31337
{
	// Fields
	private static string TAB; // 0x00
	private static List<string> _prefixInfos; // 0x08
	private static Dictionary<Transform, string> _transformPath; // 0x10

	// Nested types
	private struct TransData : IComparable<TransData> // TypeDefIndex: 31338
	{
		// Fields
		public RectTransform trans; // 0x00
		public bool alphaZero; // 0x08
		public int heirarchyOrder; // 0x0C
		public Rect rect; // 0x10
		public bool rectClipping; // 0x20
		public int materialInstanceID; // 0x24
		public string materialName; // 0x28
		public int textureID; // 0x30
		public string textureName; // 0x38
		public bool usingA8Texture; // 0x40
		public bool coplanarWithCavas; // 0x41
		public List<BottomUI> bottomUIs; // 0x48
		public int depth; // 0x50
		public BatchBreakingReason breakReason; // 0x54

		// Nested types
		public struct BottomUI // TypeDefIndex: 31339
		{
			// Fields
			public TransData transData; // 0x00
			public bool canBatch; // 0x58
		}

		// Methods
		public string GetInfo(bool validGraphic) => default; // 0x000000018523C190-0x000000018523C1C0
		public int CompareTo(TransData data) => default; // 0x000000018523B4E0-0x000000018523C190
	}

	private struct BatchData // TypeDefIndex: 31340
	{
		// Fields
		public int index; // 0x00
		public string materialName; // 0x08
		public string textureName; // 0x10
		public List<TransData> transDatas; // 0x18
		public BatchBreakingReason batchBreaking; // 0x20

		// Methods
		public string GetInfo() => default; // 0x00000001852219D0-0x0000000185221B10
	}

	private struct CanvasData : IComparable<CanvasData> // TypeDefIndex: 31341
	{
		// Fields
		public int hierarchyOrder; // 0x00
		public Canvas canvas; // 0x08
		public List<List<TransData>> subTransDatas; // 0x10
		public List<BatchData> batches; // 0x18

		// Methods
		public int CompareTo(CanvasData data) => default; // 0x0000000185221B10-0x0000000185221B60
	}

	private enum BatchBreakingReason // TypeDefIndex: 31342
	{
		NoBreaking = 0,
		CanvasInjectionBreak = 1,
		NotCoplanarWithCanvas = 2,
		DifferentMaterialInstance = 3,
		DifferentRectClipping = 4,
		DifferentTexture = 5,
		DifferentA8TextureUsage = 6,
		DifferentClipRect = 7
	}

	// Constructors
	public UIBatchAnalyzer() {} // 0x0000000185241300-0x0000000185241360
	static UIBatchAnalyzer() {} // 0x0000000185241230-0x0000000185241300

	// Methods
	private static string GetPrefixInfo(int tabs) => default; // 0x000000018523FD90-0x000000018523FFE0
	private static string GetTransformPath(Transform trans) => default; // 0x0000000185240D80-0x0000000185240FD0
	public static int AnalyseGO(GameObject go) => default; // 0x000000018523C9F0-0x000000018523CD90
	private static HashSet<Transform> GenSelectableToggleAlphaZero(List<Transform> allTrans) => default; // 0x000000018523F330-0x000000018523F790
	private static void GenCanvasTransDatas(RectTransform node, List<CanvasData> canvasDatas, int tabs, float groupAlpha, HashSet<Transform> selectableToggleAlphaZero, List<Transform> allTrans) {} // 0x000000018523D8C0-0x000000018523E790
	private static TransData GetTransData(TransData transData, Graphic graphic, float groupAlpha, HashSet<Transform> selectableToggleAlphaZero) => default; // 0x00000001852409B0-0x0000000185240D80
	private static Rect GetRect(Graphic graphic) => default; // 0x000000018523FFE0-0x00000001852409B0
	private static TransData GenTransDataDepth(TransData rawTransData, List<TransData> otherTransDatas) => default; // 0x000000018523F790-0x000000018523FD90
	private static bool Overlap(TransData a, TransData b) => default; // 0x0000000185241150-0x0000000185241230
	private static CanvasData GenCanvasBatch(CanvasData canvasData) => default; // 0x000000018523CE60-0x000000018523D8C0
	private static void GenDetailedAnalysis(List<CanvasData> canvasDatas, ref int batchCount, ref int potentialBatchableCount) {} // 0x000000018523E790-0x000000018523F330
	private static bool InjectionBreak(Transform a, Transform b, List<Transform> allTrans) => default; // 0x0000000185240FD0-0x0000000185241150
	private static BatchBreakingReason BreaksBatch(TransData a, TransData b, bool ignoreNotCoplanarWithCanvas) => default; // 0x000000018523CD90-0x000000018523CE60
}

