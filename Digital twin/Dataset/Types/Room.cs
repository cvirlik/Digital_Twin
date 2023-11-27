﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Digital_twin.Dataset.Support;
using Digital_twin.Draw_tools;
using OsmSharp;

namespace Digital_twin.Dataset.Types
{
    public class Room
    {
        private Way way { get; set; }
        private ObservableCollection<Node> nodes { get; set; }
        private ObservableCollection<Segment> segmentsOuter { get; set; } = new ObservableCollection<Segment>();
        private Building building;
        public Room(Way _way, ObservableCollection<Node> _nodes, Building _building)
        {
            way = _way;
            nodes = _nodes;
            building = _building;
            DrawingTools.SplitToSegments(nodes, segmentsOuter, building.MaxLatitude, building.MinLongitude, true);
        }
        public string Name
        {
            get
            {
                if (way.Tags.ContainsKey("ref"))
                    return way.Tags["ref"];
                else
                    return "Unnamed room";
            }
        }
        public Way Way { get { return way; } }
        public ObservableCollection<Node> Nodes { get { return nodes; } }
        public ObservableCollection<Segment> SegmentsOuter { get { return segmentsOuter; } }

    }
}
