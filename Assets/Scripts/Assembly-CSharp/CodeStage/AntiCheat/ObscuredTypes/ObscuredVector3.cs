using System;
using UnityEngine;

namespace CodeStage.AntiCheat.ObscuredTypes
{
	[Serializable]
	public struct ObscuredVector3
	{
		[Serializable]
		public struct RawEncryptedVector3
		{
			public int x;
			public int y;
			public int z;
		}

		public ObscuredVector3(float x, float y, float z) : this()
		{
		}

		[SerializeField]
		private int currentCryptoKey;
		[SerializeField]
		private RawEncryptedVector3 hiddenValue;
		[SerializeField]
		private bool inited;
		[SerializeField]
		private Vector3 fakeValue;
		[SerializeField]
		private bool fakeValueActive;
	}
}
