# Makefile for OpenAL#
# Written by Ethan "flibitijibibo" Lee

SRC = \
	src/ALC10.cs \
	src/ALC11.cs \
	src/AL10.cs \
	src/AL11.cs \
	src/ALEXT.cs \
	src/EFX.cs

build: clean
	mkdir bin
	cp OpenAL-CS.dll.config bin
	dmcs /unsafe -debug -out:bin/OpenAL-CS.dll -target:library $(SRC)

clean:
	rm -rf bin
