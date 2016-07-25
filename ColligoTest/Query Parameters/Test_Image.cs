using NUnit.Framework;
using Colligo.REST;

namespace ColligoTest
{
	[TestFixture]
	class Test_Image
	{
		Image Image;

		[SetUp]
		public void SetUp()
		{
			Image = new Image();
		}


		[Test]
		public void Image_BlackBorder250ReturnsCorrectStringValue()
		{
			Assert.AreEqual("blackborder250", Image.Sizes[Image.Types.BlackBorder250]);
		}

		[Test]
		public void Image_BlackBorder500ReturnsCorrectStringValue()
		{
			Assert.AreEqual("blackborder500", Image.Sizes[Image.Types.BlackBorder500]);
		}

		[Test]
		public void Image_BlockReturnsCorrectStringValue()
		{
			Assert.AreEqual("block", Image.Sizes[Image.Types.Block]);
		}

		[Test]
		public void Image_Block100ReturnsCorrectStringValue()
		{
			Assert.AreEqual("block100", Image.Sizes[Image.Types.Block100]);
		}

		[Test]
		public void Image_Block170ReturnsCorrectStringValue()
		{
			Assert.AreEqual("block107", Image.Sizes[Image.Types.Block107]);
		}

		[Test]
		public void Image_Block16ReturnsCorrectStringValue()
		{
			Assert.AreEqual("block16", Image.Sizes[Image.Types.Block16]);
		}

		[Test]
		public void Image_Block178ReturnsCorrectStringValue()
		{
			Assert.AreEqual("block178", Image.Sizes[Image.Types.Block178]);
		}

		[Test]
		public void Image_Block188ReturnsCorrectStringValue()
		{
			Assert.AreEqual("block188", Image.Sizes[Image.Types.Block188]);
		}

		[Test]
		public void Image_Block200ReturnsCorrectStringValue()
		{
			Assert.AreEqual("block200", Image.Sizes[Image.Types.Block200]);
		}

		[Test]
		public void Image_Block250ReturnsCorrectStringValue()
		{
			Assert.AreEqual("block250", Image.Sizes[Image.Types.Block250]);
		}

		[Test]
		public void Image_Block67ReturnsCorrectStringValue()
		{
			Assert.AreEqual("block67", Image.Sizes[Image.Types.Block67]);
		}

		[Test]
		public void Image_Block95ReturnsCorrectStringValue()
		{
			Assert.AreEqual("block95", Image.Sizes[Image.Types.Block95]);
		}

		[Test]
		public void Image_DropShadow118ReturnsCorrectStringValue()
		{
			Assert.AreEqual("dropshadow118", Image.Sizes[Image.Types.DropShadow118]);
		}

		[Test]
		public void Image_DropShadow118GreyReturnsCorrectStringValue()
		{
			Assert.AreEqual("dropshadow118grey", Image.Sizes[Image.Types.DropShadow118Grey]);
		}

		[Test]
		public void Image_DropShadow170ReturnsCorrectStringValue()
		{
			Assert.AreEqual("dropshadow170", Image.Sizes[Image.Types.DropShadow170]);
		}

		[Test]
		public void Image_DropShadow250ReturnsCorrectStringValue()
		{
			Assert.AreEqual("dropshadow250", Image.Sizes[Image.Types.DropShadow250]);
		}

		[Test]
		public void Image_DropShadow48ReturnsCorrectStringValue()
		{
			Assert.AreEqual("dropshadow48", Image.Sizes[Image.Types.DropShadow48]);
		}

		[Test]
		public void Image_DropShadow48GreyReturnsCorrectStringValue()
		{
			Assert.AreEqual("dropshadow48grey", Image.Sizes[Image.Types.DropShadow48Grey]);
		}

		[Test]
		public void Image_DropShadow92BlueReturnsCorrectStringValue()
		{
			Assert.AreEqual("dropshadow92blue", Image.Sizes[Image.Types.DropShadow92Blue]);
		}

		[Test]
		public void Image_EDPBorder250ReturnsCorrectStringValue()
		{
			Assert.AreEqual("edpborder250", Image.Sizes[Image.Types.EDPBorder250]);
		}

		[Test]
		public void Image_EDPBorder300ReturnsCorrectStringValue()
		{
			Assert.AreEqual("edpborder300", Image.Sizes[Image.Types.EDPBorder300]);
		}

		[Test]
		public void Image_EDPBorder500ReturnsCorrectStringValue()
		{
			Assert.AreEqual("edpborder500", Image.Sizes[Image.Types.EDPBorder500]);
		}

		[Test]
		public void Image_ThumbReturnsCorrectStringValue()
		{
			Assert.AreEqual("thumb", Image.Sizes[Image.Types.Thumb]);
		}

		[Test]
		public void Image_SmallReturnsCorrectStringValue()
		{
			Assert.AreEqual("small", Image.Sizes[Image.Types.Small]);
		}
			
		[Test]
		public void Image_MediumReturnsCorrectStringValue()
		{
			Assert.AreEqual("medium", Image.Sizes[Image.Types.Medium]);
		}

		[Test]
		public void Image_LargeReturnsCorrectStringValue()
		{
			Assert.AreEqual("large", Image.Sizes[Image.Types.Large]);
		}

		[Test]
		public void Image_PDPBorder250ReturnsCorrectStringValue()
		{
			Assert.AreEqual("pdpborder250", Image.Sizes[Image.Types.PDPBorder250]);
		}

		[Test]
		public void Image_PDPBorder500ReturnsCorrectStringValue()
		{
			Assert.AreEqual("pdpborder500", Image.Sizes[Image.Types.PDPBorder500]);
		}

		[Test]
		public void Image_PerspectiveCrop176By124ReturnsCorrectStringValue()
		{
			Assert.AreEqual("perspectivecrop176by124", Image.Sizes[Image.Types.PerspectiveCrop176by124]);
		}

		[Test]
		public void Image_PerspectiveCrop290By250ReturnsCorrectStringValue()
		{
			Assert.AreEqual("perspectivecrop290by250", Image.Sizes[Image.Types.PerspectiveCrop290by250]);
		}

		[Test]
		public void Image_VDPBorder250ReturnsCorrectStringValue()
		{
			Assert.AreEqual("vdpborder250", Image.Sizes[Image.Types.VDPBorder250]);
		}

		[Test]
		public void Image_VDPBorder500ReturnsCorrectStringValue()
		{
			Assert.AreEqual("vdpborder500", Image.Sizes[Image.Types.VDPBorder500]);
		}

		[Test]
		public void Image_WhiteBorder500ReturnsCorrectStringValue()
		{
			Assert.AreEqual("whiteborder500", Image.Sizes[Image.Types.WhiteBorder500]);
		}


		[Test]
		public void Image_SingleValueReturnsValidString()
		{
			string expected = "image_sizes=small";
			Image.AddValues(Image.Types.Small);

			string actual = Image.GetQuery();
			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void Image_MulitpleValueReturnsValidString()
		{
			string expected = "image_sizes=small,medium,large";
			Image.AddValues(Image.Types.Small, Image.Types.Medium, Image.Types.Large);
			string actual = Image.GetQuery();

			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void Image_NullValueReturnsNullString()
		{
			Assert.IsNull(Image.GetQuery());
		}
	}
}
