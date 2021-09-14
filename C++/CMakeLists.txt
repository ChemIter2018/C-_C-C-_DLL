cmake_minimum_required(VERSION 3.20)
project(CCPLUSDLL)

set(CMAKE_CXX_STANDARD 14)

add_library(CCPLUSDLL SHARED library.cpp)
