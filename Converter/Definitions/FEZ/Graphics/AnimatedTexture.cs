﻿namespace FEZRepacker.Converter.Definitions.FezEngine.Content
{
    [XnbType("FezEngine.Structure.AnimatedTexture")]
    [XnbReaderType("FezEngine.Readers.AnimatedTextureReader")]
    internal class AnimatedTexture
    {
        // Definition has been altered since the Texture property is
        // serialized in a different way than Texture reader does it

        [XnbProperty]
        public int AtlasWidth { get; set; }

        [XnbProperty]
        public int AtlasHeight { get; set; }

        [XnbProperty]
        public int FrameWidth { get; set; }

        [XnbProperty]
        public int FrameHeight { get; set; }

        [XnbProperty(UseConverter = true, SkipIdentifier = true)]
        public byte[] TextureData { get; set; }

        [XnbProperty(UseConverter = true)]
        public List<FrameContent> Frames { get; set; }


        public AnimatedTexture()
        {
            Frames = new();
            TextureData = new byte[0];
        }
    }
}
