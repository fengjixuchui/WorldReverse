/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public interface IChair // TypeDefIndex: 31843
{
	// Methods
	void CheckOccupied();
	bool IsFree(int index);
	bool IsOccupiedByEntity(int index, uint entityID);
	bool IsSittable(Vector3 position, SceneChairConfig.SitDownData sitData);
	void OccupiedByEntity(int index, uint entityID);
	void FreeFromEntity(int index, uint entityID);
	SceneChairConfig.SitDirection GetStandDirection(int index, float angle);
	SceneChairConfig.SitDownPoint GetSitDownPosition(int index);
	SceneChairConfig.SitDownData GetNearestSitDownPoint(Vector3 position, SceneChairConfig.SitDirection? direction, bool ignoreInteeDistance, bool ignoreOccupied = true /* Metadata: 0x00B13757 */);
	SceneChairConfig.SitDownData GetSitDownDataByID(Vector3 position, long id);
	Quaternion GetChairRotation(BaseEntity entity = null);
	Transform GetTransform();
	int GetSitUpPerformID();
	int GetSitDownPerformID();
	Vector3 ComputeSitPosition(int index, SceneChairConfig.SitDirection enterDirection, BaseEntity entity = null);
	Vector3 ComputeSitDownPosition(int index, SceneChairConfig.SitDirection enterDirection, BaseEntity entity = null);
	Quaternion ComputeSitRotation(int index, SceneChairConfig.SitDirection enterDirection);
	Vector3 GetSitPositionSimple(int index, BaseEntity entity = null);
}

