using System;
using System.Collections.Generic;
using System.Linq;
using AsepriteSharp.Models;

namespace AsepriteSharp.ModelConverters
{
    /// <summary>
    /// Handles conversion of a frame collection.
    /// </summary>
    public static class FramesConverter
    {
        /// <summary>
        /// Decodes a frame hash to a frame array.
        /// </summary>
        /// <exception cref="ArgumentNullException">Thrown when the hashtable is null.</exception>
        public static List<Frame> Decode(IDictionary<string, Frame> hashtable)
        {
            if (hashtable == null)
                throw new ArgumentNullException(nameof(hashtable));
            
            foreach (var frame in hashtable)
                frame.Value.FileName = frame.Key;
            return hashtable.Values.ToList();
        }
    }
}