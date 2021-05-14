using Digi21.DigiNG.Entities;
using Digi21.DigiNG.IO;
using System;
using System.Collections;
using System.Collections.Generic;

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
        public void Add(Entity entity, IDictionary<string, IDictionary<string, object>> databaseAttributes) => throw null;
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
    }
}
