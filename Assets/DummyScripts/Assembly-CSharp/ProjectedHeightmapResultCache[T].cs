/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public abstract class ProjectedHeightmapResultCache<T> // TypeDefIndex: 14698
	where T : struct
{
	// Fields
	public ProjectedHeightmap heightmap;
	public Vector3 lastProjectPos;
	public Vector2 projectStep;
	public uint projectSizeX;
	public uint projectSizeY;
	protected int lastProjectFrameIndex;
	protected Action<int> onTranslateDataWithXOffset;
	protected Action<int> onTranslateDataWithYOffset;
	protected T[,] _heightData;
	protected ProjectedHeightmapProcessChain _owner;
	private float _remainderX;
	private float _remainderY;

	// Constructors
	protected ProjectedHeightmapResultCache() {}

	// Methods
	public virtual void PreInit(Vector3 pos, ProjectedHeightmapProcessChain inOwner) {}
	public void Init(Vector3 pos, ProjectedHeightmapProcessChain inOwner) {}
	protected void TranslateHeightmapDataWithXoffset(int offsetx) {}
	protected void TranslateHeightmapDataWithYoffset(int offsety) {}
	protected void FullProjectHightmap(Vector3 pos) {}
	protected abstract void InternalFullProject(Vector3 pos, out Vector2 oStep, out uint oSizeX, out uint oSizeY);
	protected abstract void InternalProjectAt(Vector3 pos, int i, int j);
	protected abstract void InternalMergeHeightmap();
	protected abstract bool IsInValid();
	protected bool ShouldExecuteProject() => default;
	public void FullProject(Vector3 pos) {}
	private static void CalcDirtyData(int inOffsetSize, ref int inMin, ref int inMax, uint projectSize, Action<int> onTranslateData) {}
	private Vector3 AlignPosition(Vector3 pos, bool bForceRescan) => default;
	protected virtual bool ShouldFullProjectByYChange(float inY) => default;
	public void IncrementalProject(Vector3 pos, bool bForceRescan) {}
	private void OnRequestProjection(bool bDirty, bool bForce) {}
	public void MergeHeightmap() {}
}

