.PHONY: all
all:
	latexmk thesis

.PHONY: clean
clean:
	latexmk -C
