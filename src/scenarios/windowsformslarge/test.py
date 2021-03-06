import os
from shared.runner import TestTraits, Runner
from shared import const

SCENARIONAME = 'Windows Forms Large'
EXENAME = 'windowsformslarge'

def main():
    traits = TestTraits(exename=EXENAME,
                        guiapp='false', 
                        sdk=True,
                        )
    runner = Runner(traits)
    runner.run()


if __name__ == "__main__":
    main()
