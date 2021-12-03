ROOT := $(dir $(realpath $(lastword $(MAKEFILE_LIST))))
install:
	rm -f /etc/systemd/system/brewery.service
	ln -s $(ROOT)DevOps/brewery.service /etc/systemd/system/
	systemctl stop brewery
	systemctl daemon-reload
	systemctl enable brewery
	systemctl start brewery