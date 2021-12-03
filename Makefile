ROOT := $(dir $(realpath $(lastword $(MAKEFILE_LIST))))
install:
	ln -s $(ROOT)/DevOps/brewery.service /etc/systemd/system/
	systemctl daemon-reload
	systemctl enable brewery && systemctl start brewery