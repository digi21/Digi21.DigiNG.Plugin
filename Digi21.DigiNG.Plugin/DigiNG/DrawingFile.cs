﻿using Digi21.DigiNG.Entities;
using Digi21.DigiNG.IO;
using System;
using System.Collections;
using System.Collections.Generic;
using Digi21.Math;

namespace Digi21.DigiNG
{
    public class DrawingFile : IDrawingFile, IDisposable
    {
        public ReadOnlyComplex Add(Complex complex) => throw null;
        public void Add(Entity entity) => throw null;
        public ReadOnlyLine Add(Line line) => throw null;
        public ReadOnlyPoint Add(Point point) => throw null;
        public ReadOnlyPolygon Add(Polygon polygon) => throw null;
        public ReadOnlyText Add(Text text) => throw null;
        public void Add(IEnumerable<Entity> entities) => throw null;
        public void Backup() => throw null;
        public void Compress() => throw null;
        public void Delete(Entity entity) => throw null;
        public void Delete(IEnumerable<Entity> entities) => throw null;
        public void Dispose() => throw null;
        public IEnumerator<Entity> GetEnumerator() => throw null;
        IEnumerator IEnumerable.GetEnumerator() => throw null;
        public IEnumerator GetEnumerator2() => throw null;
        public void Undelete(Entity entity) => throw null;
        public void Undelete(IEnumerable<Entity> entities) => throw null;

        public string Wkt => throw null;
        public IDictionary<string, int> DatabaseTables => throw null;
        public bool CanWrite => throw null;
        public bool CanRead => throw null;
        public string Path => throw null;
        public string ConnectionString => throw null;

        #region IWindow3D
        public Point3D W => throw null;
        public Point3D SW => throw null;
        public Point3D S => throw null;
        public Point3D SE => throw null;
        public Point3D E => throw null;
        public Point3D NE => throw null;
        public Point3D N => throw null;
        public Point3D NW => throw null;
        public Point3D Center => throw null;
        public double Depth => throw null;
        public double Height => throw null;
        public double Width => throw null;
        public bool Valid => throw null;
        public double Zmax => throw null;
        public double Ymax => throw null;
        public double Xmax => throw null;
        public double Zmin => throw null;
        public double Ymin => throw null;
        public double? Xmin => throw null;
        #endregion

    }
}
