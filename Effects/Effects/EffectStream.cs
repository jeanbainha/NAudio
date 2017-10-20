using System;
using NAudio.Wave;

namespace Effects
{
    public class EffectStream : WaveStream
    {
        public WaveStream SourceStream
        {
            get;
            set;
        }

        public EffectStream(WaveStream stream)
        {
            this.SourceStream = stream;
        }

        public override long Length
        {
            get { return SourceStream.Length; }
        }

        public override long Position
        {
            get
            {
                return SourceStream.Position;
            }
            set
            {
                SourceStream.Position = value;
            }
        }

        public override WaveFormat WaveFormat
        {
            get { return SourceStream.WaveFormat;  }
        }

        public override int Read(byte[] buffer, int offset, int count)
        {
            return SourceStream.Read(buffer, offset, count);
        }
    }
}
