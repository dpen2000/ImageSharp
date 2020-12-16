// Copyright (c) Six Labors.
// Licensed under the Apache License, Version 2.0.

using SixLabors.ImageSharp.Formats.Experimental.Tiff.Constants;
using SixLabors.ImageSharp.Metadata.Profiles.Xmp;

namespace SixLabors.ImageSharp.Formats.Experimental.Tiff
{
    /// <summary>
    /// Provides Tiff specific metadata information for the image.
    /// </summary>
    public class TiffMetadata : IDeepCloneable
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TiffMetadata"/> class.
        /// </summary>
        public TiffMetadata()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TiffMetadata"/> class.
        /// </summary>
        /// <param name="other">The metadata to create an instance from.</param>
        private TiffMetadata(TiffMetadata other)
        {
            this.ByteOrder = other.ByteOrder;
            this.XmpProfile = other.XmpProfile;
            this.BitsPerPixel = other.BitsPerPixel;
            this.Compression = other.Compression;
        }

        /// <summary>
        /// Gets the byte order.
        /// </summary>
        public ByteOrder ByteOrder { get; internal set; }

        /// <summary>
        /// Gets the number of bits per pixel.
        /// </summary>
        public TiffBitsPerPixel BitsPerPixel { get; internal set; } = TiffBitsPerPixel.Pixel24;

        /// <summary>
        /// Gets the compression used to create the TIFF file.
        /// </summary>
        public TiffCompression Compression { get; internal set; } = TiffCompression.None;

        /// <summary>
        /// Gets the XMP profile.
        /// </summary>
        public XmpProfile XmpProfile { get; internal set; }

        /// <inheritdoc/>
        public IDeepCloneable DeepClone() => new TiffMetadata(this);
    }
}
