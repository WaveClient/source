#include <iostream>
#include <vector>
#include <Windows.h>
#include <tchar.h>
#include <tlhelp32.h>
#include "proc.h"


struct offsets
{
	DWORD LOCALPLAYER = 0x;
	DWORD LOCALPLAYERHEALTH = 0x;
  DWORD clientinstance = 0x;
  DWORD noclip = 0x;
  DWORD airjump = 0x;
  DWORD speed = 0x;
  DOWRD extra = 0x;
} offsets;

struct currentValues
{
	int currentHealthValue = 20;
  float speedvalue = 0.015;
  int airjump = 0;
  int extra - 0;
} currentValues;

struct newValues
{
	int newHealthValue = 999;
  int new speedvalue = 1;
} newValues;


int main()
{

	bool running = true;

	DWORD procId = GetProcId(L"Minecraft.Windows.exe");

	if (procId == NULL)
	{
		std::cout << "Minecraft is not found or available at the moment... Please open it!" << std::endl;
	}

	// module base address will vary from game to game
	uintptr_t moduleBase = GetModuleBaseAddress(procId, L"Minecraft.Windows.exe");

	HANDLE hProcess = 0;
	hProcess = OpenProcess(PROCESS_ALL_ACCESS, NULL, procId);

	uintptr_t dynamicPtrAddr = moduleBase + 0x10F4F4; //local player address (0x5F4F4) - module base (0x40000) which will equal 0x10F4F4

	std::vector<unsigned int> healthOffset = { offsets.LOCALPLAYERHEALTH };
	uintptr_t healthAddr = FindDMAAddy(hProcess, dynamicPtrAddr, healthOffset);
  
	std::cout << "Starting bot..." << std::endl;
	std::cout << "Module base is - 0X" << std::hex << moduleBase << std::endl;
	std::cout << "Modules loading..." << std::endl;
	std::cout << "Press Insert to exit..." << std::endl;

	while (running)
	{

		// write to health
		ReadProcessMemory(hProcess, (BYTE*)healthAddr, &currentValues.currentHealthValue, sizeof(currentValues.currentHealthValue), 0);
		WriteProcessMemory(hProcess, (BYTE*)healthAddr, &newValues.newHealthValue, sizeof(newValues.newHealthValue), 0);


		if (GetKeyState('INS') & 1)
		{
			running = false;
			std::cout << "Closing " << std::endl;
		}
	}

//yay i think i did this right -Dylan
	return 0;

}
