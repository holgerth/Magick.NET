﻿// Copyright 2013-2021 Dirk Lemstra <https://github.com/dlemstra/Magick.NET/>
//
// Licensed under the ImageMagick License (the "License"); you may not use this file except in
// compliance with the License. You may obtain a copy of the License at
//
//   https://www.imagemagick.org/script/license.php
//
// Unless required by applicable law or agreed to in writing, software distributed under the
// License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND,
// either express or implied. See the License for the specific language governing permissions
// and limitations under the License.

using System.Collections.Generic;
using ImageMagick.Defines;

namespace ImageMagick.Formats
{
    /// <summary>
    /// Class for defines that are used when a <see cref="MagickFormat.Caption"/> image is read.
    /// </summary>
    public sealed class CaptionReadDefines : ReadDefinesCreator
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CaptionReadDefines"/> class.
        /// </summary>
        public CaptionReadDefines()
          : base(MagickFormat.Caption)
        {
        }

        /// <summary>
        /// Gets or sets a the maximum font pointsize (caption:max-pointsize).
        /// </summary>
        public double? MaxFontPointsize { get; set; }

        /// <summary>
        /// Gets the defines that should be set as a define on an image.
        /// </summary>
        public override IEnumerable<IDefine> Defines
        {
            get
            {
                if (MaxFontPointsize.HasValue)
                    yield return CreateDefine("max-pointsize", MaxFontPointsize.Value);
            }
        }
    }
}