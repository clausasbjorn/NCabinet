using System;
using NCabinet.Tools;

namespace NCabinet
{
    public partial class CacheManager
    {
        private static NoKey _n;
        private static NoKey N
        {
            get { return _n ?? (_n = new NoKey()); }
        }

        public TOut Get<TIn1, TOut>(Func<TIn1, TOut> callback, TIn1 i1)
        {
            Func<TIn1, NoKey, NoKey, NoKey, NoKey, NoKey, NoKey, NoKey, NoKey, NoKey, NoKey, NoKey, NoKey, NoKey, NoKey, NoKey, TOut> wrapper = (p1, n1, n2, n3, n4, n5, n6, n7, n8, n9, n10, n11, n12, n13, n14, n15) => callback(p1);
            return Get(wrapper, i1, N, N, N, N, N, N, N, N, N, N, N, N, N, N, N, callback.Method);
        }

        public TOut Get<TIn1, TIn2, TOut>(Func<TIn1, TIn2, TOut> callback, TIn1 i1, TIn2 i2)
        {
            Func<TIn1, TIn2, NoKey, NoKey, NoKey, NoKey, NoKey, NoKey, NoKey, NoKey, NoKey, NoKey, NoKey, NoKey, NoKey, NoKey, TOut> wrapper = (p1, p2, n2, n3, n4, n5, n6, n7, n8, n9, n10, n11, n12, n13, n14, n15) => callback(p1, p2);
            return Get(wrapper, i1, i2, N, N, N, N, N, N, N, N, N, N, N, N, N, N, callback.Method);
        }

        public TOut Get<TIn1, TIn2, TIn3, TOut>(Func<TIn1, TIn2, TIn3, TOut> callback, TIn1 i1, TIn2 i2, TIn3 i3)
        {
            Func<TIn1, TIn2, TIn3, NoKey, NoKey, NoKey, NoKey, NoKey, NoKey, NoKey, NoKey, NoKey, NoKey, NoKey, NoKey, NoKey, TOut> wrapper = (p1, p2, p3, n3, n4, n5, n6, n7, n8, n9, n10, n11, n12, n13, n14, n15) => callback(p1, p2, p3);
            return Get(wrapper, i1, i2, i3, N, N, N, N, N, N, N, N, N, N, N, N, N, callback.Method);
        }

        public TOut Get<TIn1, TIn2, TIn3, TIn4, TOut>(Func<TIn1, TIn2, TIn3, TIn4, TOut> callback, TIn1 i1, TIn2 i2, TIn3 i3, TIn4 i4)
        {
            Func<TIn1, TIn2, TIn3, TIn4, NoKey, NoKey, NoKey, NoKey, NoKey, NoKey, NoKey, NoKey, NoKey, NoKey, NoKey, NoKey, TOut> wrapper = (p1, p2, p3, p4, n4, n5, n6, n7, n8, n9, n10, n11, n12, n13, n14, n15) => callback(p1, p2, p3, p4);
            return Get(wrapper, i1, i2, i3, i4, N, N, N, N, N, N, N, N, N, N, N, N, callback.Method);
        }

        public TOut Get<TIn1, TIn2, TIn3, TIn4, TIn5, TOut>(Func<TIn1, TIn2, TIn3, TIn4, TIn5, TOut> callback, TIn1 i1, TIn2 i2, TIn3 i3, TIn4 i4, TIn5 i5)
        {
            Func<TIn1, TIn2, TIn3, TIn4, TIn5, NoKey, NoKey, NoKey, NoKey, NoKey, NoKey, NoKey, NoKey, NoKey, NoKey, NoKey, TOut> wrapper = (p1, p2, p3, p4, p5, n5, n6, n7, n8, n9, n10, n11, n12, n13, n14, n15) => callback(p1, p2, p3, p4, p5);
            return Get(wrapper, i1, i2, i3, i4, i5, N, N, N, N, N, N, N, N, N, N, N, callback.Method);
        }

        public TOut Get<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TOut>(Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TOut> callback, TIn1 i1, TIn2 i2, TIn3 i3, TIn4 i4, TIn5 i5, TIn6 i6)
        {
            Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, NoKey, NoKey, NoKey, NoKey, NoKey, NoKey, NoKey, NoKey, NoKey, NoKey, TOut> wrapper = (p1, p2, p3, p4, p5, p6, n6, n7, n8, n9, n10, n11, n12, n13, n14, n15) => callback(p1, p2, p3, p4, p5, p6);
            return Get(wrapper, i1, i2, i3, i4, i5, i6, N, N, N, N, N, N, N, N, N, N, callback.Method);
        }

        public TOut Get<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TOut>(Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TOut> callback, TIn1 i1, TIn2 i2, TIn3 i3, TIn4 i4, TIn5 i5, TIn6 i6, TIn7 i7)
        {
            Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, NoKey, NoKey, NoKey, NoKey, NoKey, NoKey, NoKey, NoKey, NoKey, TOut> wrapper = (p1, p2, p3, p4, p5, p6, p7, n7, n8, n9, n10, n11, n12, n13, n14, n15) => callback(p1, p2, p3, p4, p5, p6, p7);
            return Get(wrapper, i1, i2, i3, i4, i5, i6, i7, N, N, N, N, N, N, N, N, N, callback.Method);
        }

        public TOut Get<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TOut>(Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TOut> callback, TIn1 i1, TIn2 i2, TIn3 i3, TIn4 i4, TIn5 i5, TIn6 i6, TIn7 i7, TIn8 i8)
        {
            Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, NoKey, NoKey, NoKey, NoKey, NoKey, NoKey, NoKey, NoKey, TOut> wrapper = (p1, p2, p3, p4, p5, p6, p7, p8, n8, n9, n10, n11, n12, n13, n14, n15) => callback(p1, p2, p3, p4, p5, p6, p7, p8);
            return Get(wrapper, i1, i2, i3, i4, i5, i6, i7, i8, N, N, N, N, N, N, N, N, callback.Method);
        }

        public TOut Get<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TOut>(Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TOut> callback, TIn1 i1, TIn2 i2, TIn3 i3, TIn4 i4, TIn5 i5, TIn6 i6, TIn7 i7, TIn8 i8, TIn9 i9)
        {
            Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, NoKey, NoKey, NoKey, NoKey, NoKey, NoKey, NoKey, TOut> wrapper = (p1, p2, p3, p4, p5, p6, p7, p8, p9, n9, n10, n11, n12, n13, n14, n15) => callback(p1, p2, p3, p4, p5, p6, p7, p8, p9);
            return Get(wrapper, i1, i2, i3, i4, i5, i6, i7, i8, i9, N, N, N, N, N, N, N, callback.Method);
        }

        public TOut Get<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TOut>(Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TOut> callback, TIn1 i1, TIn2 i2, TIn3 i3, TIn4 i4, TIn5 i5, TIn6 i6, TIn7 i7, TIn8 i8, TIn9 i9, TIn10 i10)
        {
            Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, NoKey, NoKey, NoKey, NoKey, NoKey, NoKey, TOut> wrapper = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, n10, n11, n12, n13, n14, n15) => callback(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10);
            return Get(wrapper, i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, N, N, N, N, N, N, callback.Method);
        }

        public TOut Get<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TOut>(Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TOut> callback, TIn1 i1, TIn2 i2, TIn3 i3, TIn4 i4, TIn5 i5, TIn6 i6, TIn7 i7, TIn8 i8, TIn9 i9, TIn10 i10, TIn11 i11)
        {
            Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, NoKey, NoKey, NoKey, NoKey, NoKey, TOut> wrapper = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, n11, n12, n13, n14, n15) => callback(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11);
            return Get(wrapper, i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, N, N, N, N, N, callback.Method);
        }

        public TOut Get<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TOut>(Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TOut> callback, TIn1 i1, TIn2 i2, TIn3 i3, TIn4 i4, TIn5 i5, TIn6 i6, TIn7 i7, TIn8 i8, TIn9 i9, TIn10 i10, TIn11 i11, TIn12 i12)
        {
            Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, NoKey, NoKey, NoKey, NoKey, TOut> wrapper = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, n12, n13, n14, n15) => callback(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12);
            return Get(wrapper, i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12, N, N, N, N, callback.Method);
        }

        public TOut Get<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TOut>(Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TOut> callback, TIn1 i1, TIn2 i2, TIn3 i3, TIn4 i4, TIn5 i5, TIn6 i6, TIn7 i7, TIn8 i8, TIn9 i9, TIn10 i10, TIn11 i11, TIn12 i12, TIn13 i13)
        {
            Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, NoKey, NoKey, NoKey, TOut> wrapper = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, n13, n14, n15) => callback(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13);
            return Get(wrapper, i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12, i13, N, N, N, callback.Method);
        }

        public TOut Get<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TOut>(Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TOut> callback, TIn1 i1, TIn2 i2, TIn3 i3, TIn4 i4, TIn5 i5, TIn6 i6, TIn7 i7, TIn8 i8, TIn9 i9, TIn10 i10, TIn11 i11, TIn12 i12, TIn13 i13, TIn14 i14)
        {
            Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, NoKey, NoKey, TOut> wrapper = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, n14, n15) => callback(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14);
            return Get(wrapper, i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12, i13, i14, N, N, callback.Method);
        }

        public TOut Get<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TOut>(Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TOut> callback, TIn1 i1, TIn2 i2, TIn3 i3, TIn4 i4, TIn5 i5, TIn6 i6, TIn7 i7, TIn8 i8, TIn9 i9, TIn10 i10, TIn11 i11, TIn12 i12, TIn13 i13, TIn14 i14, TIn15 i15)
        {
            Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, NoKey, TOut> wrapper = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, n15) => callback(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15);
            return Get(wrapper, i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12, i13, i14, i15, N, callback.Method);
        }

        public TOut Get<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TIn16, TOut>(Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TIn16, TOut> callback, TIn1 i1, TIn2 i2, TIn3 i3, TIn4 i4, TIn5 i5, TIn6 i6, TIn7 i7, TIn8 i8, TIn9 i9, TIn10 i10, TIn11 i11, TIn12 i12, TIn13 i13, TIn14 i14, TIn15 i15, TIn16 i16)
        {
            Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TIn16, TOut> wrapper = callback;
            return Get(wrapper, i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12, i13, i14, i15, i16, callback.Method);
        }

        public void Remove<TIn1, TOut>(Func<TIn1, TOut> callback, TIn1 i1)
        {
            Func<TIn1, NoKey, NoKey, NoKey, NoKey, NoKey, NoKey, NoKey, NoKey, NoKey, NoKey, NoKey, NoKey, NoKey, NoKey, NoKey, TOut> wrapper = (p1, n1, n2, n3, n4, n5, n6, n7, n8, n9, n10, n11, n12, n13, n14, n15) => callback(p1);
            Remove(wrapper, i1, N, N, N, N, N, N, N, N, N, N, N, N, N, N, N, callback.Method);
        }

        public void Remove<TIn1, TIn2, TOut>(Func<TIn1, TIn2, TOut> callback, TIn1 i1, TIn2 i2)
        {
            Func<TIn1, TIn2, NoKey, NoKey, NoKey, NoKey, NoKey, NoKey, NoKey, NoKey, NoKey, NoKey, NoKey, NoKey, NoKey, NoKey, TOut> wrapper = (p1, p2, n2, n3, n4, n5, n6, n7, n8, n9, n10, n11, n12, n13, n14, n15) => callback(p1, p2);
            Remove(wrapper, i1, i2, N, N, N, N, N, N, N, N, N, N, N, N, N, N, callback.Method);
        }

        public void Remove<TIn1, TIn2, TIn3, TOut>(Func<TIn1, TIn2, TIn3, TOut> callback, TIn1 i1, TIn2 i2, TIn3 i3)
        {
            Func<TIn1, TIn2, TIn3, NoKey, NoKey, NoKey, NoKey, NoKey, NoKey, NoKey, NoKey, NoKey, NoKey, NoKey, NoKey, NoKey, TOut> wrapper = (p1, p2, p3, n3, n4, n5, n6, n7, n8, n9, n10, n11, n12, n13, n14, n15) => callback(p1, p2, p3);
            Remove(wrapper, i1, i2, i3, N, N, N, N, N, N, N, N, N, N, N, N, N, callback.Method);
        }

        public void Remove<TIn1, TIn2, TIn3, TIn4, TOut>(Func<TIn1, TIn2, TIn3, TIn4, TOut> callback, TIn1 i1, TIn2 i2, TIn3 i3, TIn4 i4)
        {
            Func<TIn1, TIn2, TIn3, TIn4, NoKey, NoKey, NoKey, NoKey, NoKey, NoKey, NoKey, NoKey, NoKey, NoKey, NoKey, NoKey, TOut> wrapper = (p1, p2, p3, p4, n4, n5, n6, n7, n8, n9, n10, n11, n12, n13, n14, n15) => callback(p1, p2, p3, p4);
            Remove(wrapper, i1, i2, i3, i4, N, N, N, N, N, N, N, N, N, N, N, N, callback.Method);
        }

        public void Remove<TIn1, TIn2, TIn3, TIn4, TIn5, TOut>(Func<TIn1, TIn2, TIn3, TIn4, TIn5, TOut> callback, TIn1 i1, TIn2 i2, TIn3 i3, TIn4 i4, TIn5 i5)
        {
            Func<TIn1, TIn2, TIn3, TIn4, TIn5, NoKey, NoKey, NoKey, NoKey, NoKey, NoKey, NoKey, NoKey, NoKey, NoKey, NoKey, TOut> wrapper = (p1, p2, p3, p4, p5, n5, n6, n7, n8, n9, n10, n11, n12, n13, n14, n15) => callback(p1, p2, p3, p4, p5);
            Remove(wrapper, i1, i2, i3, i4, i5, N, N, N, N, N, N, N, N, N, N, N, callback.Method);
        }

        public void Remove<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TOut>(Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TOut> callback, TIn1 i1, TIn2 i2, TIn3 i3, TIn4 i4, TIn5 i5, TIn6 i6)
        {
            Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, NoKey, NoKey, NoKey, NoKey, NoKey, NoKey, NoKey, NoKey, NoKey, NoKey, TOut> wrapper = (p1, p2, p3, p4, p5, p6, n6, n7, n8, n9, n10, n11, n12, n13, n14, n15) => callback(p1, p2, p3, p4, p5, p6);
            Remove(wrapper, i1, i2, i3, i4, i5, i6, N, N, N, N, N, N, N, N, N, N, callback.Method);
        }

        public void Remove<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TOut>(Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TOut> callback, TIn1 i1, TIn2 i2, TIn3 i3, TIn4 i4, TIn5 i5, TIn6 i6, TIn7 i7)
        {
            Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, NoKey, NoKey, NoKey, NoKey, NoKey, NoKey, NoKey, NoKey, NoKey, TOut> wrapper = (p1, p2, p3, p4, p5, p6, p7, n7, n8, n9, n10, n11, n12, n13, n14, n15) => callback(p1, p2, p3, p4, p5, p6, p7);
            Remove(wrapper, i1, i2, i3, i4, i5, i6, i7, N, N, N, N, N, N, N, N, N, callback.Method);
        }

        public void Remove<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TOut>(Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TOut> callback, TIn1 i1, TIn2 i2, TIn3 i3, TIn4 i4, TIn5 i5, TIn6 i6, TIn7 i7, TIn8 i8)
        {
            Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, NoKey, NoKey, NoKey, NoKey, NoKey, NoKey, NoKey, NoKey, TOut> wrapper = (p1, p2, p3, p4, p5, p6, p7, p8, n8, n9, n10, n11, n12, n13, n14, n15) => callback(p1, p2, p3, p4, p5, p6, p7, p8);
            Remove(wrapper, i1, i2, i3, i4, i5, i6, i7, i8, N, N, N, N, N, N, N, N, callback.Method);
        }

        public void Remove<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TOut>(Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TOut> callback, TIn1 i1, TIn2 i2, TIn3 i3, TIn4 i4, TIn5 i5, TIn6 i6, TIn7 i7, TIn8 i8, TIn9 i9)
        {
            Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, NoKey, NoKey, NoKey, NoKey, NoKey, NoKey, NoKey, TOut> wrapper = (p1, p2, p3, p4, p5, p6, p7, p8, p9, n9, n10, n11, n12, n13, n14, n15) => callback(p1, p2, p3, p4, p5, p6, p7, p8, p9);
            Remove(wrapper, i1, i2, i3, i4, i5, i6, i7, i8, i9, N, N, N, N, N, N, N, callback.Method);
        }

        public void Remove<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TOut>(Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TOut> callback, TIn1 i1, TIn2 i2, TIn3 i3, TIn4 i4, TIn5 i5, TIn6 i6, TIn7 i7, TIn8 i8, TIn9 i9, TIn10 i10)
        {
            Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, NoKey, NoKey, NoKey, NoKey, NoKey, NoKey, TOut> wrapper = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, n10, n11, n12, n13, n14, n15) => callback(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10);
            Remove(wrapper, i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, N, N, N, N, N, N, callback.Method);
        }

        public void Remove<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TOut>(Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TOut> callback, TIn1 i1, TIn2 i2, TIn3 i3, TIn4 i4, TIn5 i5, TIn6 i6, TIn7 i7, TIn8 i8, TIn9 i9, TIn10 i10, TIn11 i11)
        {
            Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, NoKey, NoKey, NoKey, NoKey, NoKey, TOut> wrapper = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, n11, n12, n13, n14, n15) => callback(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11);
            Remove(wrapper, i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, N, N, N, N, N, callback.Method);
        }

        public void Remove<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TOut>(Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TOut> callback, TIn1 i1, TIn2 i2, TIn3 i3, TIn4 i4, TIn5 i5, TIn6 i6, TIn7 i7, TIn8 i8, TIn9 i9, TIn10 i10, TIn11 i11, TIn12 i12)
        {
            Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, NoKey, NoKey, NoKey, NoKey, TOut> wrapper = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, n12, n13, n14, n15) => callback(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12);
            Remove(wrapper, i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12, N, N, N, N, callback.Method);
        }

        public void Remove<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TOut>(Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TOut> callback, TIn1 i1, TIn2 i2, TIn3 i3, TIn4 i4, TIn5 i5, TIn6 i6, TIn7 i7, TIn8 i8, TIn9 i9, TIn10 i10, TIn11 i11, TIn12 i12, TIn13 i13)
        {
            Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, NoKey, NoKey, NoKey, TOut> wrapper = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, n13, n14, n15) => callback(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13);
            Remove(wrapper, i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12, i13, N, N, N, callback.Method);
        }

        public void Remove<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TOut>(Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TOut> callback, TIn1 i1, TIn2 i2, TIn3 i3, TIn4 i4, TIn5 i5, TIn6 i6, TIn7 i7, TIn8 i8, TIn9 i9, TIn10 i10, TIn11 i11, TIn12 i12, TIn13 i13, TIn14 i14)
        {
            Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, NoKey, NoKey, TOut> wrapper = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, n14, n15) => callback(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14);
            Remove(wrapper, i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12, i13, i14, N, N, callback.Method);
        }

        public void Remove<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TOut>(Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TOut> callback, TIn1 i1, TIn2 i2, TIn3 i3, TIn4 i4, TIn5 i5, TIn6 i6, TIn7 i7, TIn8 i8, TIn9 i9, TIn10 i10, TIn11 i11, TIn12 i12, TIn13 i13, TIn14 i14, TIn15 i15)
        {
            Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, NoKey, TOut> wrapper = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, n15) => callback(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15);
            Remove(wrapper, i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12, i13, i14, i15, N, callback.Method);
        }

        public void Remove<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TIn16, TOut>(Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TIn16, TOut> callback, TIn1 i1, TIn2 i2, TIn3 i3, TIn4 i4, TIn5 i5, TIn6 i6, TIn7 i7, TIn8 i8, TIn9 i9, TIn10 i10, TIn11 i11, TIn12 i12, TIn13 i13, TIn14 i14, TIn15 i15, TIn16 i16)
        {
            Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TIn16, TOut> wrapper = callback;
            Remove(wrapper, i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12, i13, i14, i15, i16, callback.Method);
        }



        public bool Exists<TIn1, TOut>(Func<TIn1, TOut> callback, TIn1 i1)
        {
            Func<TIn1, NoKey, NoKey, NoKey, NoKey, NoKey, NoKey, NoKey, NoKey, NoKey, NoKey, NoKey, NoKey, NoKey, NoKey, NoKey, TOut> wrapper = (p1, n1, n2, n3, n4, n5, n6, n7, n8, n9, n10, n11, n12, n13, n14, n15) => callback(p1);
            return Exists(wrapper, i1, N, N, N, N, N, N, N, N, N, N, N, N, N, N, N, callback.Method);
        }

        public bool Exists<TIn1, TIn2, TOut>(Func<TIn1, TIn2, TOut> callback, TIn1 i1, TIn2 i2)
        {
            Func<TIn1, TIn2, NoKey, NoKey, NoKey, NoKey, NoKey, NoKey, NoKey, NoKey, NoKey, NoKey, NoKey, NoKey, NoKey, NoKey, TOut> wrapper = (p1, p2, n2, n3, n4, n5, n6, n7, n8, n9, n10, n11, n12, n13, n14, n15) => callback(p1, p2);
            return Exists(wrapper, i1, i2, N, N, N, N, N, N, N, N, N, N, N, N, N, N, callback.Method);
        }

        public bool Exists<TIn1, TIn2, TIn3, TOut>(Func<TIn1, TIn2, TIn3, TOut> callback, TIn1 i1, TIn2 i2, TIn3 i3)
        {
            Func<TIn1, TIn2, TIn3, NoKey, NoKey, NoKey, NoKey, NoKey, NoKey, NoKey, NoKey, NoKey, NoKey, NoKey, NoKey, NoKey, TOut> wrapper = (p1, p2, p3, n3, n4, n5, n6, n7, n8, n9, n10, n11, n12, n13, n14, n15) => callback(p1, p2, p3);
            return Exists(wrapper, i1, i2, i3, N, N, N, N, N, N, N, N, N, N, N, N, N, callback.Method);
        }

        public bool Exists<TIn1, TIn2, TIn3, TIn4, TOut>(Func<TIn1, TIn2, TIn3, TIn4, TOut> callback, TIn1 i1, TIn2 i2, TIn3 i3, TIn4 i4)
        {
            Func<TIn1, TIn2, TIn3, TIn4, NoKey, NoKey, NoKey, NoKey, NoKey, NoKey, NoKey, NoKey, NoKey, NoKey, NoKey, NoKey, TOut> wrapper = (p1, p2, p3, p4, n4, n5, n6, n7, n8, n9, n10, n11, n12, n13, n14, n15) => callback(p1, p2, p3, p4);
            return Exists(wrapper, i1, i2, i3, i4, N, N, N, N, N, N, N, N, N, N, N, N, callback.Method);
        }

        public bool Exists<TIn1, TIn2, TIn3, TIn4, TIn5, TOut>(Func<TIn1, TIn2, TIn3, TIn4, TIn5, TOut> callback, TIn1 i1, TIn2 i2, TIn3 i3, TIn4 i4, TIn5 i5)
        {
            Func<TIn1, TIn2, TIn3, TIn4, TIn5, NoKey, NoKey, NoKey, NoKey, NoKey, NoKey, NoKey, NoKey, NoKey, NoKey, NoKey, TOut> wrapper = (p1, p2, p3, p4, p5, n5, n6, n7, n8, n9, n10, n11, n12, n13, n14, n15) => callback(p1, p2, p3, p4, p5);
            return Exists(wrapper, i1, i2, i3, i4, i5, N, N, N, N, N, N, N, N, N, N, N, callback.Method);
        }

        public bool Exists<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TOut>(Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TOut> callback, TIn1 i1, TIn2 i2, TIn3 i3, TIn4 i4, TIn5 i5, TIn6 i6)
        {
            Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, NoKey, NoKey, NoKey, NoKey, NoKey, NoKey, NoKey, NoKey, NoKey, NoKey, TOut> wrapper = (p1, p2, p3, p4, p5, p6, n6, n7, n8, n9, n10, n11, n12, n13, n14, n15) => callback(p1, p2, p3, p4, p5, p6);
            return Exists(wrapper, i1, i2, i3, i4, i5, i6, N, N, N, N, N, N, N, N, N, N, callback.Method);
        }

        public bool Exists<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TOut>(Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TOut> callback, TIn1 i1, TIn2 i2, TIn3 i3, TIn4 i4, TIn5 i5, TIn6 i6, TIn7 i7)
        {
            Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, NoKey, NoKey, NoKey, NoKey, NoKey, NoKey, NoKey, NoKey, NoKey, TOut> wrapper = (p1, p2, p3, p4, p5, p6, p7, n7, n8, n9, n10, n11, n12, n13, n14, n15) => callback(p1, p2, p3, p4, p5, p6, p7);
            return Exists(wrapper, i1, i2, i3, i4, i5, i6, i7, N, N, N, N, N, N, N, N, N, callback.Method);
        }

        public bool Exists<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TOut>(Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TOut> callback, TIn1 i1, TIn2 i2, TIn3 i3, TIn4 i4, TIn5 i5, TIn6 i6, TIn7 i7, TIn8 i8)
        {
            Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, NoKey, NoKey, NoKey, NoKey, NoKey, NoKey, NoKey, NoKey, TOut> wrapper = (p1, p2, p3, p4, p5, p6, p7, p8, n8, n9, n10, n11, n12, n13, n14, n15) => callback(p1, p2, p3, p4, p5, p6, p7, p8);
            return Exists(wrapper, i1, i2, i3, i4, i5, i6, i7, i8, N, N, N, N, N, N, N, N, callback.Method);
        }

        public bool Exists<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TOut>(Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TOut> callback, TIn1 i1, TIn2 i2, TIn3 i3, TIn4 i4, TIn5 i5, TIn6 i6, TIn7 i7, TIn8 i8, TIn9 i9)
        {
            Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, NoKey, NoKey, NoKey, NoKey, NoKey, NoKey, NoKey, TOut> wrapper = (p1, p2, p3, p4, p5, p6, p7, p8, p9, n9, n10, n11, n12, n13, n14, n15) => callback(p1, p2, p3, p4, p5, p6, p7, p8, p9);
            return Exists(wrapper, i1, i2, i3, i4, i5, i6, i7, i8, i9, N, N, N, N, N, N, N, callback.Method);
        }

        public bool Exists<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TOut>(Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TOut> callback, TIn1 i1, TIn2 i2, TIn3 i3, TIn4 i4, TIn5 i5, TIn6 i6, TIn7 i7, TIn8 i8, TIn9 i9, TIn10 i10)
        {
            Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, NoKey, NoKey, NoKey, NoKey, NoKey, NoKey, TOut> wrapper = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, n10, n11, n12, n13, n14, n15) => callback(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10);
            return Exists(wrapper, i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, N, N, N, N, N, N, callback.Method);
        }

        public bool Exists<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TOut>(Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TOut> callback, TIn1 i1, TIn2 i2, TIn3 i3, TIn4 i4, TIn5 i5, TIn6 i6, TIn7 i7, TIn8 i8, TIn9 i9, TIn10 i10, TIn11 i11)
        {
            Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, NoKey, NoKey, NoKey, NoKey, NoKey, TOut> wrapper = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, n11, n12, n13, n14, n15) => callback(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11);
            return Exists(wrapper, i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, N, N, N, N, N, callback.Method);
        }

        public bool Exists<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TOut>(Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TOut> callback, TIn1 i1, TIn2 i2, TIn3 i3, TIn4 i4, TIn5 i5, TIn6 i6, TIn7 i7, TIn8 i8, TIn9 i9, TIn10 i10, TIn11 i11, TIn12 i12)
        {
            Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, NoKey, NoKey, NoKey, NoKey, TOut> wrapper = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, n12, n13, n14, n15) => callback(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12);
            return Exists(wrapper, i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12, N, N, N, N, callback.Method);
        }

        public bool Exists<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TOut>(Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TOut> callback, TIn1 i1, TIn2 i2, TIn3 i3, TIn4 i4, TIn5 i5, TIn6 i6, TIn7 i7, TIn8 i8, TIn9 i9, TIn10 i10, TIn11 i11, TIn12 i12, TIn13 i13)
        {
            Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, NoKey, NoKey, NoKey, TOut> wrapper = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, n13, n14, n15) => callback(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13);
            return Exists(wrapper, i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12, i13, N, N, N, callback.Method);
        }

        public bool Exists<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TOut>(Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TOut> callback, TIn1 i1, TIn2 i2, TIn3 i3, TIn4 i4, TIn5 i5, TIn6 i6, TIn7 i7, TIn8 i8, TIn9 i9, TIn10 i10, TIn11 i11, TIn12 i12, TIn13 i13, TIn14 i14)
        {
            Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, NoKey, NoKey, TOut> wrapper = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, n14, n15) => callback(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14);
            return Exists(wrapper, i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12, i13, i14, N, N, callback.Method);
        }

        public bool Exists<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TOut>(Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TOut> callback, TIn1 i1, TIn2 i2, TIn3 i3, TIn4 i4, TIn5 i5, TIn6 i6, TIn7 i7, TIn8 i8, TIn9 i9, TIn10 i10, TIn11 i11, TIn12 i12, TIn13 i13, TIn14 i14, TIn15 i15)
        {
            Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, NoKey, TOut> wrapper = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, n15) => callback(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15);
            return Exists(wrapper, i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12, i13, i14, i15, N, callback.Method);
        }

        public bool Exists<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TIn16, TOut>(Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TIn16, TOut> callback, TIn1 i1, TIn2 i2, TIn3 i3, TIn4 i4, TIn5 i5, TIn6 i6, TIn7 i7, TIn8 i8, TIn9 i9, TIn10 i10, TIn11 i11, TIn12 i12, TIn13 i13, TIn14 i14, TIn15 i15, TIn16 i16)
        {
            Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TIn16, TOut> wrapper = callback;
            return Exists(wrapper, i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12, i13, i14, i15, i16, callback.Method);
        }
    }
}