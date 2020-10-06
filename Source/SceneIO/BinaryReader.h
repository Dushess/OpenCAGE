#pragma once

#include <string>
#include <fstream>

#include "CommonMisc.h"

struct OffsetAndCount {
public:
	int offset_position = 0;
	int count_at_offset = 0;
};

class BinaryReader {
public:
	BinaryReader(std::string filepath) {
		file_stream.open(filepath, std::ifstream::binary);
		if (!file_stream.is_open()) throw std::runtime_error("ERROR! Couldn't load requested binary file.");

		file_stream.seekg(0, file_stream.end);
		file_length = file_stream.tellg();
		file_stream.seekg(0, file_stream.beg);
	}
	~BinaryReader() {
		Close();
	}

	template<typename T>
	void Read(T& readTo, int position = -1);

	char* ReadBytes(int length, int position = -1) {
		char* char_array = new char[length] {};
		for (int i = 0; i < length; i++) {
			char this_char;
			Read(this_char, (position == -1) ? -1 : position + i);
			char_array[i] = this_char;
		}
		return char_array;
	}

	Vector3 ReadVec3(int position = -1) {
		float x, y, z;
		Read(x, position); Read(y); Read(z);
		return Vector3(x, y, z);
	}
	Vector2 ReadVec2(int position = -1) {
		float x, y;
		Read(x, position); Read(y);
		return Vector2(x, y);
	}

	//String must have been written in C# standard formatting
	std::string ReadString(int position = -1) {
		int8_t len;
		Read(len, position);
		std::string out = "";
		for (int i = 0; i < len; i++) {
			char c;
			Read(c);
			out += c;
		}
		return out;
	}

	int GetPosition() {
		return file_offset;
	}
	void SetPosition(int new_pos) {
		file_offset = new_pos;
	}

	int GetLength() {
		return file_length;
	}

	void Close() {
		file_stream.close();
	}

private:
	std::ifstream file_stream;
	int file_length;
	int file_offset = 0;
};

template<typename T>
inline void BinaryReader::Read(T& readTo, int position)
{
	if (position != -1) file_offset = position;
	file_stream.seekg(file_offset, file_stream.beg); //todo: only do this when position != -1?
	file_stream.read((char*)&readTo, sizeof(T));
	file_offset += sizeof(T);
}
