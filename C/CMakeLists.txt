cmake_minimum_required(VERSION 3.20)
project(CCDLL C)

set(CMAKE_C_STANDARD 99)

add_library(CCDLL SHARED library.c)
