// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.
using MixedRealityExtension.Animation;
using Newtonsoft.Json.Linq;
using System;

namespace MixedRealityExtension.Patching.Types
{
	public class LookAtPatch : Patchable<LookAtPatch>, IPatchable
	{
		[PatchProperty]
		public Guid? ActorId { get; set; }

		[PatchProperty]
		public LookAtMode? Mode { get; set; }

		[PatchProperty]
		public bool? Backward { get; set; }

		public void WriteToPath(TargetPath path, JToken value, int depth)
		{

		}

		public bool ReadFromPath(TargetPath path, ref JToken value, int depth)
		{
			return false;
		}

		public void Clear()
		{

		}

		public void Restore(TargetPath path, int depth)
		{

		}

		public void RestoreAll()
		{

		}
	}
}
