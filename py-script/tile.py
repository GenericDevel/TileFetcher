# ---------------------------------------------------------------------
# File      : main.py
# Desc      : The main module of this web-tile fetcher program.
# Author    : Li G.Q.
# Date      : 2021/9/30/
# Copyright : These codes are developed based on the works by Zheng Jie.
#             https://github.com/zhengjie9510/google-map-downloader
#             These program are used freely under the GPL-3.0.
# ----------------------------------------------------------------------


import argparse
import TileFetcher
import time
import Utils


parser = argparse.ArgumentParser(description = 'Tile Fetcher argparse')
parser.add_argument('--east'    , '-e', help = 'east longtitude'    , required=True );
parser.add_argument('--north'   , '-n', help = 'north latitude'     , required=True );
parser.add_argument('--west'    , '-w', help = 'west longtitude'    , required=True );
parser.add_argument('--south'   , '-s', help = 'south lattitude'    , required=True );
parser.add_argument('--zoom'    , '-z', help = 'zoom or level'      , required=True );

args = parser.parse_args()
# print("ARGS: east ",args.east);

if not (Utils.is_digital(args.west.strip()) and Utils.is_digital(args.east.strip()) 
        and Utils.is_digital(args.north.strip()) and Utils.is_digital(args.south.strip()) 
        and Utils.is_digital(args.zoom.strip())):
    raise TypeError("east,west,north,south and zoom must be int or float!")

east    = float(args.east);
west    = float(args.west);
north   = float(args.north);
south   = float(args.south);
zoom    = int(args.zoom);

if __name__ == '__main__':
    try:
        
        #main(100.361, 38.866, 100.386, 38.839, 13, r'D:\Temp\test.tif', server="Google")
        #count=TileFetcher.get_tile_count(114.652447, 23.615226, 114.656534, 23.611870, 21)
        count=TileFetcher.get_tile_count(west, north, east, south, zoom);
        print(count);
    except Exception as e:
        print(" ##Fatal error: ",e);