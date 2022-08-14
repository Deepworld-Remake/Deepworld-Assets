using System;
using UnityEngine;

namespace CodeStage.AntiCheat.ObscuredTypes
{
	[Serializable]
	public struct ObscuredBool
	{
		private ObscuredBool(bool value) : this()
		{
		}

		[SerializeField]
		private byte currentCryptoKey;
		[SerializeField]
		private int hiddenValue;
		[SerializeField]
		private bool inited;
		[SerializeField]
		private bool fakeValue;
		[SerializeField]
		private bool fakeValueActive;
	}
}
