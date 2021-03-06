/*
	BlamLib: .NET SDK for the Blam Engine

	See license\BlamLib\BlamLib for specific license information
*/
using System;
using System.Xml.Serialization;

namespace BlamLib.Render.COLLADA.Enums
{
	[SerializableAttribute()]
	[XmlTypeAttribute(Namespace = "http://www.collada.org/2005/11/COLLADASchema")]
	public enum ColladaFXSurfaceFaceEnum
	{
		POSITIVE_X,
		NEGATIVE_X,
		POSITIVE_Y,
		NEGATIVE_Y,
		POSITIVE_Z,
		NEGATIVE_Z
	}
}